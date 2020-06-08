using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using NetClasses;

namespace OleXisTest
{
    class ExcelTestResultsSaver
    {
        public ExcelTestResultsSaver() 
        {
        }

        public void Save(string path, string testName, List<ExtendedResultSheetItem> results)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(path, SpreadsheetDocumentType.Workbook))
            {

                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();

                FileVersion fv = new FileVersion();
                fv.ApplicationName = "Microsoft Office Excel";
                worksheetPart.Worksheet = new Worksheet(new SheetData());
                WorkbookStylesPart wbsp = workbookPart.AddNewPart<WorkbookStylesPart>();

                //Styles
                wbsp.Stylesheet = GenerateStyleSheet();
                wbsp.Stylesheet.Save();

                // Задаем колонки и их ширину
                Columns lstColumns = worksheetPart.Worksheet.GetFirstChild<Columns>();
                Boolean needToInsertColumns = false;
                if (lstColumns == null)
                {
                    lstColumns = new Columns();
                    needToInsertColumns = true;
                }
                lstColumns.Append(new Column() { Min = 1, Max = 10, Width = 20, CustomWidth = true });
                lstColumns.Append(new Column() { Min = 2, Max = 10, Width = 20, CustomWidth = true });
                lstColumns.Append(new Column() { Min = 3, Max = 10, Width = 20, CustomWidth = true });
                lstColumns.Append(new Column() { Min = 4, Max = 10, Width = 20, CustomWidth = true });
                lstColumns.Append(new Column() { Min = 5, Max = 10, Width = 20, CustomWidth = true });
                lstColumns.Append(new Column() { Min = 6, Max = 10, Width = 20, CustomWidth = true });
                lstColumns.Append(new Column() { Min = 7, Max = 10, Width = 20, CustomWidth = true });
                if (needToInsertColumns)
                    worksheetPart.Worksheet.InsertAt(lstColumns, 0);


                //Создаем лист в книге
                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = testName };
                sheets.Append(sheet);

                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                //Question headers
                Row row = new Row() { RowIndex = 1 };
                sheetData.Append(row);
                InsertCell(row, 1, "Номер", CellValues.String, 0);
                InsertCell(row, 2, "Имя/Фамилия", CellValues.String, 0);
                InsertCell(row, 3, "Дата", CellValues.String, 0);
                InsertCell(row, 4, "Время выполнения", CellValues.String, 0);
                InsertCell(row, 5, "Оценка", CellValues.String, 0);
                int colIndex = 6;
                Dictionary<string, int> questionTitles = new Dictionary<string, int>();
                foreach (var result in results)
                    foreach (var extResult in result.ExtendedResult)
                        if (!questionTitles.ContainsKey(extResult.QuestionName))
                        {
                            questionTitles.Add(extResult.QuestionName, colIndex);
                            InsertCell(row, colIndex++, ReplaceHexadecimalSymbols(extResult.QuestionName), CellValues.String, 0);
                        }
                //Results
                uint rowIndex = 2;
                foreach (var result in results)
                {
                    row = new Row() { RowIndex = rowIndex++ };
                    sheetData.Append(row);
                    InsertCell(row, 1, ReplaceHexadecimalSymbols(result.id.ToString()), CellValues.Number, 1);
                    InsertCell(row, 2, ReplaceHexadecimalSymbols(result.NameSurname), CellValues.String, 0);
                    InsertCell(row, 3, ReplaceHexadecimalSymbols(result.PassDate.ToString("dd.MM.yyyy")), CellValues.String, 2);
                    InsertCell(row, 4, ReplaceHexadecimalSymbols(result.PassingTime.ToString("hh:mm:ss")), CellValues.String, 3);
                    InsertCell(row, 5, ReplaceHexadecimalSymbols(result.Mark.ToString()), CellValues.Number, (uint)(result.Mark < 4 ? 5 : 4));
                    foreach(var extResult in result.ExtendedResult)
                        InsertCell(row, questionTitles[extResult.QuestionName], extResult.IsRight ? ReplaceHexadecimalSymbols(extResult.Question_score.ToString()) : "0", CellValues.Number, (uint)(extResult.IsRight ? 4 : 5));
                }

                workbookPart.Workbook.Save();
                document.Close();
                MessageBox.Show("Успешно сохранено", "Вывод в Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static void InsertCell(Row row, int cell_num, string val, CellValues type, uint styleIndex)
        {
            Cell refCell = null;
            Cell newCell = new Cell() { CellReference = cell_num.ToString() + ":" + row.RowIndex.ToString(), StyleIndex = styleIndex };
            row.InsertBefore(newCell, refCell);

            newCell.CellValue = new CellValue(val);
            newCell.DataType = new EnumValue<CellValues>(type);
        }

        //Delete special symbols
        static string ReplaceHexadecimalSymbols(string txt)
        {
            string r = "[\x00-\x08\x0B\x0C\x0E-\x1F\x26]";
            return Regex.Replace(txt, r, "", RegexOptions.Compiled);
        }

        //Style generation
        static Stylesheet GenerateStyleSheet()
        {
            return new Stylesheet(
                new Fonts(
                    new Font(                                                               // Стиль 0 - Шрифт по умолчанию
                        new FontSize() { Val = 11 },
                        new Color() { Rgb = new HexBinaryValue() { Value = "000000" } },
                        new FontName() { Val = "Calibri" })
                ),
                new Fills(
                    new Fill(                                                           // Стиль 0 - Заполнение ячейки по умолчанию
                        new PatternFill() { PatternType = PatternValues.None }),
                    new Fill(                                                           // Стиль 1 - Заполнение ячейки зеленым
                        new PatternFill(
                            new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "FFFF0000" } }
                            )
                        { PatternType = PatternValues.Solid }),
                    new Fill(                                                           // Стиль 2 - Заполнение ячейки красным
                        new PatternFill(
                            new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "FFAAAA" } }
                        )
                        { PatternType = PatternValues.Solid }),
                   new Fill(                                                           // Стиль 3 - Заполнение ячейки зеленым
                        new PatternFill(
                            new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "90EE90" } }
                            )
                        { PatternType = PatternValues.Solid })
                ),
                new Borders(
                    new Border(                                                         // Стиль 0
                        new LeftBorder(),
                        new RightBorder(),
                        new TopBorder(),
                        new BottomBorder(),
                        new DiagonalBorder())
                ),
                new CellFormats(
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 0, FillId = 0, BorderId = 0, NumberFormatId = 49 },                          // Стиль под номером 0 - по умолчанию
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 0, FillId = 0, BorderId = 0, NumberFormatId = 3 },                          // Стиль под номером 1 - цифровой по умолчанию
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 0, FillId = 0, BorderId = 0, ApplyFont = true, NumberFormatId = 15 },       // Стиль 2 Дата
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 0, FillId = 0, BorderId = 0, ApplyFont = true, NumberFormatId = 21 },       // Стиль под номером 3 Время
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 0, FillId = 3, BorderId = 0, ApplyFill = true, NumberFormatId = 3 },       // Стиль под номером 4 Зеленый номер
                    new CellFormat(new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center, WrapText = true }) { FontId = 0, FillId = 2, BorderId = 0, ApplyFill = true, NumberFormatId = 3 }       // Стиль под номером 5 Красный номер
                )
            );
        }
    }
}
