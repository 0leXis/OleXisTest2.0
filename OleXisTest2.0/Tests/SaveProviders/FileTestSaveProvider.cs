using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace OleXisTest
{
    class FileTestSaveProvider
    {
        public string FileName { 
            get
            {
                return _fileName;
            } 
        }

        private const string tmpDir = "tmp";
        private string _fileName = null;
        public bool Save(ITest test, string testPath = null)
        {
            if (testPath == null)
                using (var saveDialog = new SaveFileDialog())
                {
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                        _fileName = saveDialog.FileName;
                    else
                        return false;
                }
            else
                _fileName = testPath;
            FileProcessor.ClearTmpDir(tmpDir);

            for (var i = 0; i < test.Questions.Count; i++)
            {
                var serialized_question = test.Questions[i].Serialize();
                using (FileStream file = new FileStream(tmpDir + @"\" + i + ".dat", FileMode.OpenOrCreate))
                {
                    serialized_question.WriteTo(file);
                }
            }

            var formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(tmpDir + @"\main.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, test);
            }

            FileProcessor.CompressFile(tmpDir, tmpDir + @"\testtmp.test");
            if (test.Params.Password != "")
            {
                if (File.Exists(_fileName))
                    File.Delete(_fileName);
                FileProcessor.EncryptDecryptFile(tmpDir + @"\testtmp.test", test.Params.Password, true, _fileName);
            }
            else
            {
                if (File.Exists(_fileName))
                    File.Delete(_fileName);
                File.Copy(tmpDir + @"\testtmp.test", _fileName);
            }

            FileProcessor.ClearTmpDir(tmpDir);

            return true;
        }

        public ITest Load(string password = null)
        {
            using (var openDialog = new OpenFileDialog())
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    return LoadForEdit(openDialog.FileName, password);
                }
            }
            return null;
        }

        public ITest LoadForEdit(string fileName, string password = null)
        {
            _fileName = fileName;

            FileProcessor.ClearTmpDir(tmpDir);

            if (password == null)
            {
                FileProcessor.DecompressFile(fileName, "");
            }
            else
            {
                FileProcessor.EncryptDecryptFile(fileName, password, false, tmpDir + @"\testtmp.test");
                FileProcessor.DecompressFile(tmpDir + @"\testtmp.test", "");
            }

            var formatter = new BinaryFormatter();
            Test test;
            using (FileStream file = new FileStream(tmpDir + @"\main.dat", FileMode.Open))
            {
                test = (Test)formatter.Deserialize(file);
                test.InitSerializedTest();
            }

            var i = 0;
            while (File.Exists(tmpDir + @"\" + i.ToString() + ".dat"))
            {
                using (FileStream file = new FileStream(tmpDir + @"\" + i.ToString() + ".dat", FileMode.Open))
                {
                    test.Questions.Add(new Question(file));
                }
                i++;
            }

            FileProcessor.ClearTmpDir(tmpDir);

            return test;
        }

        public ITest LoadForPass(string fileName, string password = null)
        {
            return LoadForEdit(fileName, password);
        }
    }
}
