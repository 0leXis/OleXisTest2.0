using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OleXisTest
{
    //Типы вопросов
    //public enum QuestionType { SingleChoose, MultiChoose, AlternativeChoose, AccordanceEstablishment, SequenceEstablishment, FreeStatement }

    //Класс для хранения информации о вопросе
    [Serializable]
    public class Question : IQuestion, ICloneable
    {
        //Тип вопроса
        //public QuestionType QuestionType { get; set; } = QuestionType.SingleChoose;
        //Раздел
        public string Section { get; set; }
        //Название
        public string Name { get; set; }

        public IQuestionInfo QuestionInfo { get; set; }
        public IQuestionAnswer QuestionAnswer { get; set; }

        public Question(string Name, IQuestionInfo QuestionInfo, IQuestionAnswer QuestionAnswer, string Section = null) 
        {
            this.QuestionInfo = QuestionInfo;
            this.QuestionAnswer = QuestionAnswer;
            this.Name = Name;
            this.Section = Section;
        }

        public Question(Question questionToClone) 
        {
            //QuestionType = questionToClone.QuestionType;
            Section = questionToClone.Section;
            Name = questionToClone.Name;
            QuestionInfo = questionToClone.QuestionInfo;
            QuestionAnswer = questionToClone.QuestionAnswer;
        }

        public Question(Stream serialized_question_stream) : this(Deserialize(serialized_question_stream))
        {
            //using (FileStream file = new FileStream(path + @"\" + fileName, FileMode.OpenOrCreate))
            //{
            //    question = (Question)formatter.Deserialize(file);
            //}
            //if (question._imageFile != null)
            //{
            //    var Img = new MemoryStream(File.ReadAllBytes(path + @"\" + question._imageFile));
            //    question.Image = new Bitmap(Img);
            //}
            //return question;
        }

        public object Clone()
        {
            return new Question(this);
        }

        private static Question Deserialize(Stream question_stream)
        {
            var formatter = new BinaryFormatter();
            return (Question)formatter.Deserialize(question_stream);
        }

        //public void Serialize(string path, string fileName)
        public MemoryStream Serialize()
        {
            //if (Image != null)
            //{
            //    var i = 0;
            //    while (true)
            //    {
            //        if (File.Exists(path + @"\" + i.ToString() + ".png"))
            //            i++;
            //        else
            //            break;
            //    }
            //    Image.Save(path + @"\" + i.ToString() + ".png");
            //    _imageFile = i + ".png";
            //}
            var formatter = new BinaryFormatter();
            var serializationStream = new MemoryStream();
            formatter.Serialize(serializationStream, this);
            serializationStream.Position = 0;
            return serializationStream;
            //using (FileStream file = new FileStream(path + @"\" + fileName, FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(file, this);
            //}
        }
    }
}