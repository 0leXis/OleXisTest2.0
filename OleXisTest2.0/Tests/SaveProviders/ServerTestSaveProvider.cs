using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NetClasses;

namespace OleXisTest
{
    class ServerTestSaveProvider
    {
        public string Error
        {
            get
            {
                return _error;
            }
        }
        private const string tmpDir = "tmp";
        private NetConnection connection;
        private string _error;
        private ITest loadedTest;
        public ServerTestSaveProvider(NetConnection connection)
        {
            this.connection = connection;
        }
        public bool Save(ITest test, string testName, int subject)
        {
            if (testName == null)
                throw new ArgumentNullException("Значение testName не может быть null");
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

            var stream = new MemoryStream();
            FileProcessor.CompressFile(tmpDir, stream);
            var testInfo = new NetSerializedTestInfo(stream.ToArray(), testName, subject);

            _error = null;
            connection.SendCommand(
                new RequestInfo(
                    "SaveTest",
                    SequrityUtils.Encrypt(
                        testInfo.ToJson(),
                        connection.User.SecretKey),
                    connection.User.UserToken),
                    onSaveRecive
                );

            FileProcessor.ClearTmpDir(tmpDir);
            if (_error == null)
                return true;
            else
                return false;
        }

        private void onSaveRecive(string data)
        {
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
                _error = response.Error;
            else
            if(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey) != "OK")
                _error = "UNKNOWN_ERROR";
        }

        public ITest LoadForEdit(string testName)
        {
            _error = null;
            connection.SendCommand(
                new RequestInfo(
                    "LoadTestForEdit",
                    SequrityUtils.Encrypt(
                        testName,
                        connection.User.SecretKey),
                    connection.User.UserToken),
                    onLoadRecive
                );

            return loadedTest;
        }

        public ITest LoadForPass(string testName)
        {
            _error = null;
            connection.SendCommand(
                new RequestInfo(
                    "LoadTestForPass",
                    SequrityUtils.Encrypt(
                        testName,
                        connection.User.SecretKey),
                    connection.User.UserToken),
                    onLoadRecive
                );

            return loadedTest;
        }

        private void onLoadRecive(string data)
        {
            loadedTest = null;
            var response = ResponseInfo.FromJson(data);
            if (response.Error != null)
                _error = response.Error;
            else
            {
                FileProcessor.ClearTmpDir(tmpDir);

                var testInfo = NetSerializedTestInfo.FromJson(SequrityUtils.DecryptString(response.Data, connection.User.SecretKey));
                using (FileStream file = new FileStream(tmpDir + @"\testtmp.test", FileMode.OpenOrCreate))
                {
                    file.Write(testInfo.Test, 0, testInfo.Test.Length);
                }

                FileProcessor.DecompressFile(tmpDir + @"\testtmp.test", "");
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
                loadedTest = test;
            }
        }
    }
}
