using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    public partial class SimpleQuestionInfoView : UserControl, IQuestionInfoView
    {
        byte[] sound;
        public SimpleQuestionInfoView(SimpleQuestionInfo info)
        {
            this.sound = info.Sound;
            InitializeComponent();
            if(sound != null)
            {
                sound = (byte[])info.Sound.Clone();
                buttonPlaySound.Visible = true;
            }
            else
                buttonPlaySound.Visible = false;
            labelVoprText.Text = info.Text;
            if(info.Image != null)
                pictureBox1.Image = new Bitmap(info.Image);
        }

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
            SoundSystem.PlaySound(sound);
        }
    }
}
