namespace OleXisTest
{
    partial class TestParamsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGeneratePass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuestions = new System.Windows.Forms.TextBox();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonEachSection = new System.Windows.Forms.RadioButton();
            this.radioButton1Variant = new System.Windows.Forms.RadioButton();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGeneratePass
            // 
            this.buttonGeneratePass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneratePass.Location = new System.Drawing.Point(16, 280);
            this.buttonGeneratePass.Name = "buttonGeneratePass";
            this.buttonGeneratePass.Size = new System.Drawing.Size(322, 31);
            this.buttonGeneratePass.TabIndex = 28;
            this.buttonGeneratePass.Text = "Сгенерировать пароль";
            this.buttonGeneratePass.UseVisualStyleBackColor = true;
            this.buttonGeneratePass.Click += new System.EventHandler(this.buttonGeneratePass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(93, 245);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(222, 29);
            this.textBoxPassword.TabIndex = 22;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(178, 353);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 31);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(13, 353);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(159, 31);
            this.buttonOk.TabIndex = 26;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxQuestions);
            this.groupBox1.Controls.Add(this.radioButtonRandom);
            this.groupBox1.Controls.Add(this.radioButtonEachSection);
            this.groupBox1.Controls.Add(this.radioButton1Variant);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 167);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Распределение вариантов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Всего вопросов:";
            // 
            // textBoxQuestions
            // 
            this.textBoxQuestions.Enabled = false;
            this.textBoxQuestions.Location = new System.Drawing.Point(165, 121);
            this.textBoxQuestions.Name = "textBoxQuestions";
            this.textBoxQuestions.Size = new System.Drawing.Size(134, 29);
            this.textBoxQuestions.TabIndex = 3;
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(6, 94);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(293, 27);
            this.radioButtonRandom.TabIndex = 2;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Генерировать случайный вариант";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButtonRandom_CheckedChanged);
            // 
            // radioButtonEachSection
            // 
            this.radioButtonEachSection.AutoSize = true;
            this.radioButtonEachSection.Location = new System.Drawing.Point(6, 61);
            this.radioButtonEachSection.Name = "radioButtonEachSection";
            this.radioButtonEachSection.Size = new System.Drawing.Size(313, 27);
            this.radioButtonEachSection.TabIndex = 1;
            this.radioButtonEachSection.TabStop = true;
            this.radioButtonEachSection.Text = "Использовать разделы как варианты";
            this.radioButtonEachSection.UseVisualStyleBackColor = true;
            // 
            // radioButton1Variant
            // 
            this.radioButton1Variant.AutoSize = true;
            this.radioButton1Variant.Location = new System.Drawing.Point(6, 28);
            this.radioButton1Variant.Name = "radioButton1Variant";
            this.radioButton1Variant.Size = new System.Drawing.Size(272, 27);
            this.radioButton1Variant.TabIndex = 0;
            this.radioButton1Variant.TabStop = true;
            this.radioButton1Variant.Text = "1 Вариант (все вопросы теста)";
            this.radioButton1Variant.UseVisualStyleBackColor = true;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "Не ограничено",
            "5",
            "10",
            "20",
            "45",
            "60"});
            this.comboBoxTime.Location = new System.Drawing.Point(16, 35);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(159, 31);
            this.comboBoxTime.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Время на прохождение (минут)";
            // 
            // TestParamsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 397);
            this.Controls.Add(this.buttonGeneratePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.label1);
            this.Name = "TestParamsDialog";
            this.Text = "TestParams";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGeneratePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuestions;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonEachSection;
        private System.Windows.Forms.RadioButton radioButton1Variant;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label1;
    }
}