﻿namespace OleXisTest
{
    partial class SimpleInfoEditControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveSound = new System.Windows.Forms.Button();
            this.buttonPlaySound = new System.Windows.Forms.Button();
            this.buttonAddSound = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemoveSound);
            this.groupBox2.Controls.Add(this.buttonPlaySound);
            this.groupBox2.Controls.Add(this.buttonAddSound);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(256, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 257);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Звук";
            // 
            // buttonRemoveSound
            // 
            this.buttonRemoveSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonRemoveSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonRemoveSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSound.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveSound.Location = new System.Drawing.Point(6, 60);
            this.buttonRemoveSound.Name = "buttonRemoveSound";
            this.buttonRemoveSound.Size = new System.Drawing.Size(235, 28);
            this.buttonRemoveSound.TabIndex = 7;
            this.buttonRemoveSound.Text = "Удалить звуковой файл";
            this.buttonRemoveSound.UseVisualStyleBackColor = false;
            this.buttonRemoveSound.Click += new System.EventHandler(this.buttonRemoveSound_Click);
            // 
            // buttonPlaySound
            // 
            this.buttonPlaySound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonPlaySound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonPlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaySound.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlaySound.Location = new System.Drawing.Point(6, 147);
            this.buttonPlaySound.Name = "buttonPlaySound";
            this.buttonPlaySound.Size = new System.Drawing.Size(235, 56);
            this.buttonPlaySound.TabIndex = 6;
            this.buttonPlaySound.Text = "Прослушать звуковой файл";
            this.buttonPlaySound.UseVisualStyleBackColor = false;
            this.buttonPlaySound.Click += new System.EventHandler(this.buttonPlaySound_Click);
            // 
            // buttonAddSound
            // 
            this.buttonAddSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonAddSound.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonAddSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSound.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddSound.Location = new System.Drawing.Point(6, 26);
            this.buttonAddSound.Name = "buttonAddSound";
            this.buttonAddSound.Size = new System.Drawing.Size(235, 28);
            this.buttonAddSound.TabIndex = 5;
            this.buttonAddSound.Text = "Добавить звуковой файл";
            this.buttonAddSound.UseVisualStyleBackColor = false;
            this.buttonAddSound.Click += new System.EventHandler(this.buttonAddSound_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRemoveImage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonAddImage);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 257);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изображение";
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveImage.Location = new System.Drawing.Point(6, 60);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Size = new System.Drawing.Size(235, 28);
            this.buttonRemoveImage.TabIndex = 8;
            this.buttonRemoveImage.Text = "Удалить изображение";
            this.buttonRemoveImage.UseVisualStyleBackColor = false;
            this.buttonRemoveImage.Click += new System.EventHandler(this.buttonRemoveImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Предпросмотр:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonAddImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddImage.Location = new System.Drawing.Point(6, 26);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(235, 28);
            this.buttonAddImage.TabIndex = 4;
            this.buttonAddImage.Text = "Добавить изображение";
            this.buttonAddImage.UseVisualStyleBackColor = false;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxText.Location = new System.Drawing.Point(3, 22);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(500, 96);
            this.textBoxText.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Текст вопроса:";
            // 
            // SimpleInfoEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.label1);
            this.Name = "SimpleInfoEditControl";
            this.Size = new System.Drawing.Size(507, 388);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRemoveSound;
        private System.Windows.Forms.Button buttonPlaySound;
        private System.Windows.Forms.Button buttonAddSound;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemoveImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
    }
}
