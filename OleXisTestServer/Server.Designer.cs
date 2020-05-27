namespace OleXisTestServer
{
    partial class Server
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.textBoxLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLog.Location = new System.Drawing.Point(22, 33);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(474, 418);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сообщения:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(504, 33);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(263, 28);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Запустить сервер";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(507, 71);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(263, 28);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Остановить сервер";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.button1);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowTeachRegister);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowGroupAdd);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowSubjectAdd);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowStudRegister);
            this.groupBoxParams.Controls.Add(this.checkBoxAllowRegister);
            this.groupBoxParams.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxParams.Location = new System.Drawing.Point(507, 99);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(261, 352);
            this.groupBoxParams.TabIndex = 6;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(7, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Настройки БД";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // checkBoxAllowTeachRegister
            // 
            this.checkBoxAllowTeachRegister.AutoSize = true;
            this.checkBoxAllowTeachRegister.Location = new System.Drawing.Point(6, 122);
            this.checkBoxAllowTeachRegister.Name = "checkBoxAllowTeachRegister";
            this.checkBoxAllowTeachRegister.Size = new System.Drawing.Size(224, 61);
            this.checkBoxAllowTeachRegister.TabIndex = 9;
            this.checkBoxAllowTeachRegister.Text = "Разрешить преподавателям \r\nрегистрировать \r\nпреподавателей\r\n";
            this.checkBoxAllowTeachRegister.UseVisualStyleBackColor = true;
            this.checkBoxAllowTeachRegister.CheckedChanged += new System.EventHandler(this.checkBoxAllowTeachRegister_CheckedChanged);
            // 
            // checkBoxAllowGroupAdd
            // 
            this.checkBoxAllowGroupAdd.AutoSize = true;
            this.checkBoxAllowGroupAdd.Location = new System.Drawing.Point(6, 256);
            this.checkBoxAllowGroupAdd.Name = "checkBoxAllowGroupAdd";
            this.checkBoxAllowGroupAdd.Size = new System.Drawing.Size(224, 42);
            this.checkBoxAllowGroupAdd.TabIndex = 8;
            this.checkBoxAllowGroupAdd.Text = "Разрешить преподавателям \r\nдобавлять группы/классы\r\n";
            this.checkBoxAllowGroupAdd.UseVisualStyleBackColor = true;
            this.checkBoxAllowGroupAdd.CheckedChanged += new System.EventHandler(this.checkBoxAllowGroupAdd_CheckedChanged);
            // 
            // checkBoxAllowSubjectAdd
            // 
            this.checkBoxAllowSubjectAdd.AutoSize = true;
            this.checkBoxAllowSubjectAdd.Location = new System.Drawing.Point(6, 189);
            this.checkBoxAllowSubjectAdd.Name = "checkBoxAllowSubjectAdd";
            this.checkBoxAllowSubjectAdd.Size = new System.Drawing.Size(224, 61);
            this.checkBoxAllowSubjectAdd.TabIndex = 7;
            this.checkBoxAllowSubjectAdd.Text = "Разрешить преподавателям \r\nдобавлять \r\nдисциплины/предметы\r\n";
            this.checkBoxAllowSubjectAdd.UseVisualStyleBackColor = true;
            this.checkBoxAllowSubjectAdd.CheckedChanged += new System.EventHandler(this.checkBoxAllowSubjectAdd_CheckedChanged);
            // 
            // checkBoxAllowStudRegister
            // 
            this.checkBoxAllowStudRegister.AutoSize = true;
            this.checkBoxAllowStudRegister.Location = new System.Drawing.Point(6, 74);
            this.checkBoxAllowStudRegister.Name = "checkBoxAllowStudRegister";
            this.checkBoxAllowStudRegister.Size = new System.Drawing.Size(224, 42);
            this.checkBoxAllowStudRegister.TabIndex = 6;
            this.checkBoxAllowStudRegister.Text = "Разрешить преподавателям \r\nрегистрировать учащихся";
            this.checkBoxAllowStudRegister.UseVisualStyleBackColor = true;
            this.checkBoxAllowStudRegister.CheckedChanged += new System.EventHandler(this.checkBoxAllowStudRegister_CheckedChanged);
            // 
            // checkBoxAllowRegister
            // 
            this.checkBoxAllowRegister.AutoSize = true;
            this.checkBoxAllowRegister.Location = new System.Drawing.Point(6, 26);
            this.checkBoxAllowRegister.Name = "checkBoxAllowRegister";
            this.checkBoxAllowRegister.Size = new System.Drawing.Size(200, 42);
            this.checkBoxAllowRegister.TabIndex = 5;
            this.checkBoxAllowRegister.Text = "Разрешить принимать \r\nзапросы на регистрацию";
            this.checkBoxAllowRegister.UseVisualStyleBackColor = true;
            this.checkBoxAllowRegister.CheckedChanged += new System.EventHandler(this.checkBoxAllowRegister_CheckedChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 464);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLog);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.Text = "OleXis Test: Сервер";
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
        private System.Windows.Forms.Button button1;
    }
}

