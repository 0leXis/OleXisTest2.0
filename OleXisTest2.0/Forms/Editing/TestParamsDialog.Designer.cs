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
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonEachSection = new System.Windows.Forms.RadioButton();
            this.radioButton1Variant = new System.Windows.Forms.RadioButton();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeneratePass
            // 
            this.buttonGeneratePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonGeneratePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonGeneratePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneratePass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneratePass.Location = new System.Drawing.Point(12, 247);
            this.buttonGeneratePass.Name = "buttonGeneratePass";
            this.buttonGeneratePass.Size = new System.Drawing.Size(323, 28);
            this.buttonGeneratePass.TabIndex = 28;
            this.buttonGeneratePass.Text = "Сгенерировать пароль";
            this.buttonGeneratePass.UseVisualStyleBackColor = false;
            this.buttonGeneratePass.Click += new System.EventHandler(this.buttonGeneratePass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(83, 214);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(213, 27);
            this.textBoxPassword.TabIndex = 22;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(175, 281);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 28);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(11, 281);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(160, 28);
            this.buttonOk.TabIndex = 26;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonRandom);
            this.groupBox1.Controls.Add(this.radioButtonEachSection);
            this.groupBox1.Controls.Add(this.radioButton1Variant);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 147);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Распределение вариантов";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.numericUpDownCount.Location = new System.Drawing.Point(130, 110);
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(154, 27);
            this.numericUpDownCount.TabIndex = 5;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Всего вопросов:";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(6, 84);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(260, 23);
            this.radioButtonRandom.TabIndex = 2;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Генерировать случайный вариант";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButtonRandom_CheckedChanged);
            // 
            // radioButtonEachSection
            // 
            this.radioButtonEachSection.AutoSize = true;
            this.radioButtonEachSection.Location = new System.Drawing.Point(6, 55);
            this.radioButtonEachSection.Name = "radioButtonEachSection";
            this.radioButtonEachSection.Size = new System.Drawing.Size(281, 23);
            this.radioButtonEachSection.TabIndex = 1;
            this.radioButtonEachSection.TabStop = true;
            this.radioButtonEachSection.Text = "Использовать разделы как варианты";
            this.radioButtonEachSection.UseVisualStyleBackColor = true;
            // 
            // radioButton1Variant
            // 
            this.radioButton1Variant.AutoSize = true;
            this.radioButton1Variant.Location = new System.Drawing.Point(6, 26);
            this.radioButton1Variant.Name = "radioButton1Variant";
            this.radioButton1Variant.Size = new System.Drawing.Size(234, 23);
            this.radioButton1Variant.TabIndex = 0;
            this.radioButton1Variant.TabStop = true;
            this.radioButton1Variant.Text = "1 Вариант (все вопросы теста)";
            this.radioButton1Variant.UseVisualStyleBackColor = true;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "Не ограничено",
            "5",
            "10",
            "20",
            "45",
            "60"});
            this.comboBoxTime.Location = new System.Drawing.Point(12, 31);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(159, 27);
            this.comboBoxTime.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Время на прохождение (минут)";
            // 
            // TestParamsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 319);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGeneratePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestParamsDialog";
            this.Text = "OleXis Test: Параметры теста";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonEachSection;
        private System.Windows.Forms.RadioButton radioButton1Variant;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
    }
}