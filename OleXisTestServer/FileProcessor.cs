using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleXisTestServer
{
    public static class FileProcessor
    {
        public const string TESTS_DIR = "tests";
        public static void SaveTestFile(string fileName, byte[] test)
        {
            if (!Directory.Exists(TESTS_DIR))
                Directory.CreateDirectory(TESTS_DIR);
            using (var fs = new FileStream(TESTS_DIR + "/" + fileName, FileMode.OpenOrCreate))
            {
                fs.Write(test, 0, test.Length);
            }
        }

        public static byte[] LoadTestFile(string fileName)
        {
            byte[] test;
            using (var fs = new FileStream(TESTS_DIR + "/" + fileName, FileMode.Open))
            {
                test = new byte[fs.Length];
                fs.Read(test, 0, test.Length);
            }
            return test;
        }
    }
}
