using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using Ionic.Zip;
using Ionic.Zlib;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;

namespace OleXisTest
{
    //Тип распределения вопросов
    [Serializable]
    public enum QuestionAllocation { One_Variant, Section_Variant, Generate}

    //Параметры теста
    [Serializable]
    public class TestParams
    { 
        //Пароль
        public string Password { get; set; } = "";
        //Время на прохождение
        public int TimeForTest { get; set; } = 0;
        //Вариант распределения вопросов
        public QuestionAllocation QuestionAllocation { get; set; } = QuestionAllocation.One_Variant;
        //Кол-во вопросов из каждого раздела для случ варианта
        public int CountForGenerate { get; set; } = 0;

        public TestParams() { }
        public void SetParams(TestParams paramsToSet) 
        {
            Password = paramsToSet.Password;
            TimeForTest = paramsToSet.TimeForTest;
            QuestionAllocation = paramsToSet.QuestionAllocation;
            CountForGenerate = paramsToSet.CountForGenerate;
        }
    }

    //Класс для хранения данных теста
    [Serializable]
    public class Test : ITest
    {
        //Вопросы
        public List<IQuestion> Questions
        {
            get
            {
                return _questions;
            }
        }
        //Разделы
        public List<string> Sections { get; } = new List<string>();
        //Параметры
        public TestParams Params { get; } = new TestParams();
        [NonSerialized]
        private List<IQuestion> _questions = new List<IQuestion>();

        public Test() { }

        public void InitSerializedTest()
        {
            if(_questions == null)
                _questions = new List<IQuestion>();
        }
    }
}
