using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OleXisTest
{
    [Serializable]
    public class SimpleQuestionInfo : IQuestionInfo, ICloneable
    {
        //Информация о вопросе
        public string Text { get; set; } = "";
        //[field: NonSerialized]
        public Bitmap Image { get; set; } = null;
        //[field: NonSerialized]
        //public string SoundFileExt { get; set; } = null;
        public byte[] Sound { get; set; } = null;

        //private string _imageFile = null;
        public SimpleQuestionInfo() { }

        public SimpleQuestionInfo(SimpleQuestionInfo infoToClone)
        {
            Text = infoToClone.Text;
            if(infoToClone.Image != null)
                Image = new Bitmap(infoToClone.Image);
            if (infoToClone.Sound == null)
                Sound = null;
            else
                Sound = (byte[])infoToClone.Sound.Clone();
        }

        public object Clone()
        {
            return new SimpleQuestionInfo(this);
        }

        public string GetShortDescription()
        {
            return Text;
        }
    }
}
