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
    public partial class SimpleInfoEditControl : UserControl, IInfoEditControl
    {
        private SimpleQuestionInfo _info;
        public SimpleInfoEditControl()
        {
            InitializeComponent();
            _info = new SimpleQuestionInfo();
            buttonPlaySound.Enabled = false;
            buttonRemoveSound.Enabled = false;
            buttonRemoveImage.Enabled = false;
        }

        public SimpleInfoEditControl(SimpleQuestionInfo info)
        {
            InitializeComponent();
            _info = new SimpleQuestionInfo(info);
            if (_info.Text != null)
                textBoxText.Text = _info.Text;
            if (_info.Image != null)
            {
                pictureBox1.Image = _info.Image;
                buttonRemoveImage.Enabled = true;
            }
            else
                buttonRemoveImage.Enabled = false;
            if (_info.Sound != null)
            {
                buttonPlaySound.Enabled = true;
                buttonRemoveSound.Enabled = true;
            }
            else
            {
                buttonRemoveSound.Enabled = false;
                buttonRemoveImage.Enabled = false;
            }
        }
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            RemoveImage();
            var image = FileProcessor.LoadImage();
            if (image != null)
            {
                pictureBox1.Image = image;
                _info.Image = image;
                buttonRemoveImage.Enabled = true;
            }
            else
            {
                //TODO: error
            }
        }

        private void buttonRemoveImage_Click(object sender, EventArgs e)
        {
            RemoveImage();
        }

        private void RemoveImage()
        {
            buttonRemoveImage.Enabled = false;
            pictureBox1.Image = null;
            _info.Image = null;
        }

        private void buttonAddSound_Click(object sender, EventArgs e)
        {
            RemoveSound();
            var sound = FileProcessor.LoadSound();
            if (sound != null)
            {
                _info.Sound = sound;
                buttonPlaySound.Enabled = true;
                buttonRemoveSound.Enabled = true;
            }
            else
            {
                //TODO: error
            }
        }

        private void buttonRemoveSound_Click(object sender, EventArgs e)
        {
            RemoveSound();
        }

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
            SoundSystem.PlaySound(_info.Sound);
        }

        private void RemoveSound()
        {
            _info.Sound = null;
            buttonPlaySound.Enabled = false;
            buttonRemoveSound.Enabled = false;
        }

        public IQuestionInfo GetInfo()
        {
            _info.Text = textBoxText.Text;
            return _info;
        }

        public bool ValidateInfo()
        {
            GetInfo();
            if (_info.Text == "" || _info.Text == null)
            {
                MessageBox.Show("Поле \"Текст вопроса\" должно быть заполнено", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
