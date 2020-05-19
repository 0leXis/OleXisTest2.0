namespace OleXisTestServer
{
    partial class Menu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxAllowTeachRegister = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowGroupAdd = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowSubjectAdd = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowStudRegister = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowRegister = new System.Windows.Forms.CheckBox();
            this.groupBoxParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(22, 44);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(474, 407);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сообщения:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(504, 9);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(263, 36);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Запустить сервер";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(504, 55);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(263, 36);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Остановить сервер";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxAllowTeachRegister);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowGroupAdd);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowSubjectAdd);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowStudRegister);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowRegister);
            this.groupBoxParams.Location = new System.Drawing.Point(507, 99);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(261, 352);
            this.groupBoxParams.TabIndex = 6;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxAllowTeachRegister
            // 
            this.checkBoxAllowTeachRegister.AutoSize = true;
            this.checkBoxAllowTeachRegister.Location = new System.Drawing.Point(6, 140);
            this.checkBoxAllowTeachRegister.Name = "checkBoxAllowTeachRegister";
            this.checkBoxAllowTeachRegister.Size = new System.Drawing.Size(254, 73);
            this.checkBoxAllowTeachRegister.TabIndex = 9;
            this.checkBoxAllowTeachRegister.Text = "Разрешить преподавателям \r\nрегистрировать \r\nпреподавателей\r\n";
            this.checkBoxAllowTeachRegister.UseVisualStyleBackColor = true;
            this.checkBoxAllowTeachRegister.CheckedChanged += new System.EventHandler(this.checkBoxAllowTeachRegister_CheckedChanged);
            // 
            // checkBoxAllowGroupAdd
            // 
            this.checkBoxAllowGroupAdd.AutoSize = true;
            this.checkBoxAllowGroupAdd.Location = new System.Drawing.Point(6, 296);
            this.checkBoxAllowGroupAdd.Name = "checkBoxAllowGroupAdd";
            this.checkBoxAllowGroupAdd.Size = new System.Drawing.Size(254, 50);
            this.checkBoxAllowGroupAdd.TabIndex = 8;
            this.checkBoxAllowGroupAdd.Text = "Разрешить преподавателям \r\nдобавлять группы/классы\r\n";
            this.checkBoxAllowGroupAdd.UseVisualStyleBackColor = true;
            this.checkBoxAllowGroupAdd.CheckedChanged += new System.EventHandler(this.checkBoxAllowGroupAdd_CheckedChanged);
            // 
            // checkBoxAllowSubjectAdd
            // 
            this.checkBoxAllowSubjectAdd.AutoSize = true;
            this.checkBoxAllowSubjectAdd.Location = new System.Drawing.Point(0, 219);
            this.checkBoxAllowSubjectAdd.Name = "checkBoxAllowSubjectAdd";
            this.checkBoxAllowSubjectAdd.Size = new System.Drawing.Size(254, 73);
            this.checkBoxAllowSubjectAdd.TabIndex = 7;
            this.checkBoxAllowSubjectAdd.Text = "Разрешить преподавателям \r\nдобавлять \r\nдисциплины/предметы\r\n";
            this.checkBoxAllowSubjectAdd.UseVisualStyleBackColor = true;
            this.checkBoxAllowSubjectAdd.CheckedChanged += new System.EventHandler(this.checkBoxAllowSubjectAdd_CheckedChanged);
            // 
            // checkBoxAllowStudRegister
            // 
            this.checkBoxAllowStudRegister.AutoSize = true;
            this.checkBoxAllowStudRegister.Location = new System.Drawing.Point(6, 84);
            this.checkBoxAllowStudRegister.Name = "checkBoxAllowStudRegister";
            this.checkBoxAllowStudRegister.Size = new System.Drawing.Size(254, 50);
            this.checkBoxAllowStudRegister.TabIndex = 6;
            this.checkBoxAllowStudRegister.Text = "Разрешить преподавателям \r\nрегистрировать учащихся";
            this.checkBoxAllowStudRegister.UseVisualStyleBackColor = true;
            this.checkBoxAllowStudRegister.CheckedChanged += new System.EventHandler(this.checkBoxAllowStudRegister_CheckedChanged);
            // 
            // checkBoxAllowRegister
            // 
            this.checkBoxAllowRegister.AutoSize = true;
            this.checkBoxAllowRegister.Location = new System.Drawing.Point(6, 28);
            this.checkBoxAllowRegister.Name = "checkBoxAllowRegister";
            this.checkBoxAllowRegister.Size = new System.Drawing.Size(222, 50);
            this.checkBoxAllowRegister.TabIndex = 5;
            this.checkBoxAllowRegister.Text = "Разрешить принимать \r\nзапросы на регистрацию";
            this.checkBoxAllowRegister.UseVisualStyleBackColor = true;
            this.checkBoxAllowRegister.CheckedChanged += new System.EventHandler(this.checkBoxAllowRegister_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 466);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLog);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxAllowGroupAdd;
        private System.Windows.Forms.CheckBox checkBoxAllowSubjectAdd;
        private System.Windows.Forms.CheckBox checkBoxAllowStudRegister;
        private System.Windows.Forms.CheckBox checkBoxAllowRegister;
        private System.Windows.Forms.CheckBox checkBoxAllowTeachRegister;
    }
}

