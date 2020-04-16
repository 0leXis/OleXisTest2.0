namespace OleXisTest
{
    partial class TestPassing
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
            if(answerControl != null)
                answerControl.Dispose();
            if (infoControl != null)
                infoControl.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.buttonStopTest = new System.Windows.Forms.Button();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.timerTestTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(200, 351);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(169, 23);
            this.labelTime.TabIndex = 24;
            this.labelTime.Text = "Времени осталось:";
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextQuestion.Location = new System.Drawing.Point(461, 347);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(182, 30);
            this.buttonNextQuestion.TabIndex = 23;
            this.buttonNextQuestion.Text = "Следующий вопрос";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // buttonStopTest
            // 
            this.buttonStopTest.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopTest.Location = new System.Drawing.Point(12, 347);
            this.buttonStopTest.Name = "buttonStopTest";
            this.buttonStopTest.Size = new System.Drawing.Size(182, 30);
            this.buttonStopTest.TabIndex = 22;
            this.buttonStopTest.Text = "Закончить тест";
            this.buttonStopTest.UseVisualStyleBackColor = true;
            this.buttonStopTest.Click += new System.EventHandler(this.buttonStopTest_Click);
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnswer.Location = new System.Drawing.Point(12, 172);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Size = new System.Drawing.Size(631, 169);
            this.groupBoxAnswer.TabIndex = 21;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "Ответы";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(631, 160);
            this.groupBoxInfo.TabIndex = 20;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Вопрос";
            // 
            // timerTestTime
            // 
            this.timerTestTime.Interval = 1000;
            this.timerTestTime.Tick += new System.EventHandler(this.timerTestTime_Tick);
            // 
            // TestPassing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 389);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.buttonStopTest);
            this.Controls.Add(this.groupBoxAnswer);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "TestPassing";
            this.Text = "TestPassing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Button buttonStopTest;
        private System.Windows.Forms.GroupBox groupBoxAnswer;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Timer timerTestTime;
    }
}