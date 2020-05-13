using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;
using System.IO;
using Ionic.Zip;
using Ionic.Zlib;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace OleXisTest
{
    class FileProcessor
    {
        public static void CompressFile(string inFilesPath, string outFilePath)
        {
            using (ZipFile Zip = new ZipFile())
            {
                Zip.CompressionLevel = CompressionLevel.BestCompression;
                foreach (var File in Directory.GetFiles(inFilesPath))
                    Zip.AddFile(File);
                Zip.Save(outFilePath);
            }
        }

        public static void CompressFile(string inFilesPath, Stream outFileStream)
        {
            using (ZipFile Zip = new ZipFile())
            {
                Zip.CompressionLevel = CompressionLevel.BestCompression;
                foreach (var File in Directory.GetFiles(inFilesPath))
                    Zip.AddFile(File);
                Zip.Save(outFileStream);
            }
        }

        public static void DecompressFile(string inFilePath, string outFilesPath)
        {
            using (ZipFile Zip = new ZipFile(inFilePath))
            {
                Zip.ExtractAll(outFilesPath);
            }
        }

        public static void ClearTmpDir(string tmpPath)
        {
            if (Directory.Exists(tmpPath))
            {
                Directory.Delete(tmpPath, true);
                Directory.CreateDirectory(tmpPath);
            }
            else
            {
                Directory.CreateDirectory(tmpPath);
            }
        }

        public static Bitmap LoadImage()
        {
            using (var op = new OpenFileDialog())
            {
                op.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    return new Bitmap(op.FileName);
                }
            }
            return null;
        }

        public static byte[] LoadSound()
        {
            using (var op = new OpenFileDialog())
            {
                op.Filter = "MP3 (.mp3)|*.mp3|Wave (.wav)|*.wav";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    using (var FileStr = File.OpenRead(op.FileName))
                    {
                        if (FileStr.Length > int.MaxValue)
                        {
                            MessageBox.Show("Ошибка: длинна файла слишком велика");
                        }
                        else
                        {
                            var soundFile = new byte[FileStr.Length];
                            FileStr.Read(soundFile, 0, (int)FileStr.Length);
                            return soundFile;
                        }
                    }
                }
            }
            return null;
        }

        public static ITest LoadTestFile(out string fileName)
        {
            var loader = new FileTestSaveProvider();
            try
            {
                var test = loader.Load();
                if (test != null)
                {
                    fileName = loader.FileName;
                    return test;
                }
            }
            catch (Ionic.Zip.ZipException)
            {
                fileName = loader.FileName;
                MessageBox.Show("Файл защищен паролем. Нажмите ОК, чтобы ввести пароль", "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                while (true)
                {
                    using (var passDialog = new PasswordDialog())
                    {
                        if (passDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                var test = loader.LoadForEdit(fileName, passDialog.Password);
                                if (test != null)
                                {
                                    fileName = loader.FileName;
                                    return test;
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Введен неверный пароль либо тест поврежден", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            break;
                    }
                }
            }
            fileName = "";
            return null;
        }

        public static bool SaveTestFile(ITest test, out string fileName)
        {
            var saver = new FileTestSaveProvider();
            fileName = saver.FileName;
            return saver.Save(test);
        }

        //Шифрование и расшифровка
        public static void EncryptDecryptFile(string InputPath, string Password, bool IsEncryptMode, string OutputPath)
        {
            using (var Сypher = new AesManaged())
            using (var FileStrIn = new FileStream(InputPath, FileMode.Open))
            using (var FileStrOut = new FileStream(OutputPath, FileMode.Create))
            {
                const int SaltLength = 256;
                var Salt = new byte[SaltLength];
                var IV = new byte[Сypher.BlockSize / 8];

                if (IsEncryptMode)
                {
                    // Генерация соли и вектора инициализации
                    using (var RNG = new RNGCryptoServiceProvider())
                    {
                        RNG.GetBytes(Salt);
                        RNG.GetBytes(IV);
                    }
                    FileStrOut.Write(Salt, 0, Salt.Length);
                    FileStrOut.Write(IV, 0, IV.Length);
                }
                else
                {
                    // Считывание соли и вектора из файла
                    FileStrIn.Read(Salt, 0, SaltLength);
                    FileStrIn.Read(IV, 0, IV.Length);
                }

                // Генерация пароля
                var PDB = new Rfc2898DeriveBytes(Password, Salt);
                var Key = PDB.GetBytes(Сypher.KeySize / 8);

                // Шифрование и расшифровка
                using (var CryptoTransform = IsEncryptMode ? Сypher.CreateEncryptor(Key, IV) : Сypher.CreateDecryptor(Key, IV))
                using (var CryptStr = new CryptoStream(FileStrOut, CryptoTransform, CryptoStreamMode.Write))
                {
                    FileStrIn.CopyTo(CryptStr);
                }
            }
        }
    }
}
