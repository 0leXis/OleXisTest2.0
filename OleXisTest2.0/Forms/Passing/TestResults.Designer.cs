namespace OleXisTest
{
    partial class TestResults
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
            this.button2 = new System.Windows.Forms.Button();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelProcPrav = new System.Windows.Forms.Label();
            this.labelOcenka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(219, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Список ответов";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelClass.Location = new System.Drawing.Point(12, 28);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(107, 19);
            this.labelClass.TabIndex = 19;
            this.labelClass.Text = "Класс\\Группа: ";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFIO.Location = new System.Drawing.Point(12, 9);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(49, 19);
            this.labelFIO.TabIndex = 18;
            this.labelFIO.Text = "ФИО: ";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(12, 111);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(201, 28);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTime.Location = new System.Drawing.Point(12, 66);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 19);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "Время: ";
            // 
            // labelProcPrav
            // 
            this.labelProcPrav.AutoSize = true;
            this.labelProcPrav.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcPrav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProcPrav.Location = new System.Drawing.Point(12, 47);
            this.labelProcPrav.Name = "labelProcPrav";
            this.labelProcPrav.Size = new System.Drawing.Size(172, 19);
            this.labelProcPrav.TabIndex = 15;
            this.labelProcPrav.Text = "% правильных ответов: ";
            // 
            // labelOcenka
            // 
            this.labelOcenka.AutoSize = true;
            this.labelOcenka.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOcenka.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelOcenka.Location = new System.Drawing.Point(12, 85);
            this.labelOcenka.Name = "labelOcenka";
            this.labelOcenka.Size = new System.Drawing.Size(81, 23);
            this.labelOcenka.TabIndex = 14;
            this.labelOcenka.Text = "Оценка: ";
            // 
            // TestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 148);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelProcPrav);
            this.Controls.Add(this.labelOcenka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestResults";
            this.Text = "OleXis Test: Результаты тестирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelProcPrav;
        private System.Windows.Forms.Label labelOcenka;
    }
}