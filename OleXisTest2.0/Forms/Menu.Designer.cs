namespace OleXisTest
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
            this.btnRunFile = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelLoginStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonRunServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunFile
            // 
            this.btnRunFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunFile.Location = new System.Drawing.Point(12, 12);
            this.btnRunFile.Name = "btnRunFile";
            this.btnRunFile.Size = new System.Drawing.Size(269, 29);
            this.btnRunFile.TabIndex = 0;
            this.btnRunFile.Text = "Выполнить тест (из файла)";
            this.btnRunFile.UseVisualStyleBackColor = true;
            this.btnRunFile.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditor.Location = new System.Drawing.Point(12, 79);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(269, 29);
            this.btnEditor.TabIndex = 0;
            this.btnEditor.Text = "Создать/Редактировать тест";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(12, 114);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(269, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Подключиться к серверу";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Enabled = false;
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassword.Location = new System.Drawing.Point(291, 152);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(222, 61);
            this.btnPassword.TabIndex = 0;
            this.btnPassword.Text = "Сменить пароль";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // btnDB
            // 
            this.btnDB.Enabled = false;
            this.btnDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDB.Location = new System.Drawing.Point(12, 149);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(269, 29);
            this.btnDB.TabIndex = 0;
            this.btnDB.Text = "Управление информацией БД";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(12, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(269, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelLoginStatus
            // 
            this.labelLoginStatus.AutoSize = true;
            this.labelLoginStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginStatus.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLoginStatus.Location = new System.Drawing.Point(287, 13);
            this.labelLoginStatus.Name = "labelLoginStatus";
            this.labelLoginStatus.Size = new System.Drawing.Size(221, 23);
            this.labelLoginStatus.TabIndex = 1;
            this.labelLoginStatus.Text = "Соединение не установлено";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(287, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            this.labelName.Visible = false;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(287, 80);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(77, 23);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Фамилия";
            this.labelSurname.Visible = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(287, 103);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 23);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Логин";
            this.labelLogin.Visible = false;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(287, 126);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(59, 23);
            this.labelGroup.TabIndex = 5;
            this.labelGroup.Text = "Группа";
            this.labelGroup.Visible = false;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(287, 36);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 23);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Роль";
            this.labelRole.Visible = false;
            // 
            // buttonRunServer
            // 
            this.buttonRunServer.Enabled = false;
            this.buttonRunServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunServer.Location = new System.Drawing.Point(12, 45);
            this.buttonRunServer.Name = "buttonRunServer";
            this.buttonRunServer.Size = new System.Drawing.Size(269, 29);
            this.buttonRunServer.TabIndex = 7;
            this.buttonRunServer.Text = "Выполнить тест (с сервера)";
            this.buttonRunServer.UseVisualStyleBackColor = true;
            this.buttonRunServer.Click += new System.EventHandler(this.buttonRunServer_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 217);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRunServer);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLoginStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.btnRunFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunFile;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelLoginStatus;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonRunServer;
    }
}

