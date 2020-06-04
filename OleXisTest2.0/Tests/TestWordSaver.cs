using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OleXisTest
{
    class TestWordSaver : IWordAnswerPrinter
    {
        MainDocumentPart mainPart;
        Body body;
        int lastColumnId = 1;
        public TestWordSaver() { }

        public string Save(ITest test, string path)
        {
            try
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Create(
                    path, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    //Doc structure
                    mainPart = doc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    body = mainPart.Document.AppendChild(new Body());

                    NumberingDefinitionsPart numberingPart =
                    mainPart.AddNewPart<NumberingDefinitionsPart>("numberpart1");
                    Numbering element =
                      new Numbering(
                        new AbstractNum(
                          new Level(
                            new NumberingFormat() { Val = NumberFormatValues.Bullet },
                            new LevelText() { Val = "·" })
                          { LevelIndex = 0 })
                        { AbstractNumberId = 1 },
                        new NumberingInstance(
                          new AbstractNumId() { Val = 1 })
                        { NumberID = 1 });
                    element.Save(numberingPart);

                    foreach (var question in test.Questions)
                    {
                        Paragraph para = body.AppendChild(new Paragraph());
                        var info = new StringBuilder(question.QuestionAnswer.GetQuestionTaskInfo());
                        info.Append(" (");
                        info.Append(question.QuestionAnswer.QuestionScore);
                        info.Append(" баллов)");

                        Run run = para.AppendChild(new Run());
                        run.PrependChild(GetStyle(true));
                        run.AppendChild(new Text(info.ToString()));

                        run = para.AppendChild(new Run());
                        run.PrependChild(GetStyle(false));
                        run.AppendChild(new Break());
                        run.AppendChild(new Text(question.QuestionInfo.GetShortDescription()));

                        question.QuestionAnswer.ToWord(this as IWordAnswerPrinter);
                    }
                }
            }
            catch(Exception e)
            {
                return e.Message;
            }
            return null;
        }

        public void AddColumn(List<string> answers)
        {
            lastColumnId++;
            Paragraph para;
            foreach (var answer in answers)
            {
                para = body.AppendChild(new Paragraph());
                para.PrependChild(GetListProperties(lastColumnId));
                var run = para.AppendChild(new Run());
                run.PrependChild(GetStyle(false));
                run.AppendChild(new Text(answer));
            }
            para = body.AppendChild(new Paragraph());
        }

        public void AddString(string str)
        {
            var para = body.AppendChild(new Paragraph());
            var run = para.AppendChild(new Run());
            run.PrependChild(GetStyle(false));
            run.AppendChild(new Text(str));
            run.AppendChild(new Break());
        }

        private RunProperties GetStyle(bool isBold)
        {
            //Doc style
            var runProp = new RunProperties();
            var runFont = new RunFonts { Ascii = "Arial" };
            var size = new FontSize { Val = new StringValue("24") };
            runProp.Append(runFont);
            runProp.Append(size);
            if (isBold)
            {
                var runStyle = new Bold();
                runProp.Append(runStyle);
            }
            return runProp;
        }

        private ParagraphProperties GetListProperties(int id)
        {
            var paragraphProperties = new ParagraphProperties();
            var paragraphStyleId = new ParagraphStyleId() { Val = "ListParagraph" };
            var numbering = new NumberingProperties(
                new NumberingLevelReference() { Val = 0 },
                new NumberingId() { Val = id });
            var spacing = new SpacingBetweenLines()
            {
                After = "0",
                Before = "0"
            };
            paragraphProperties.AppendChild(numbering);
            paragraphProperties.AppendChild(spacing);
            paragraphProperties.AppendChild(paragraphStyleId);
            return paragraphProperties;
        }
    }
}
