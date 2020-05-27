namespace OleXisTest
{
    partial class EditUserInfoForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxPassConfirm = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.checkBoxChangePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(194, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 28);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(8, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(180, 28);
            this.btnOK.TabIndex = 48;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Подтверждение пароля:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(6, 189);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(103, 19);
            this.labelGroup.TabIndex = 46;
            this.labelGroup.Text = "Группа/Класс:";
            this.labelGroup.Visible = false;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGroup.Location = new System.Drawing.Point(116, 186);
            this.textBoxGroup.MaxLength = 10;
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(258, 27);
            this.textBoxGroup.TabIndex = 47;
            this.textBoxGroup.Visible = false;
            this.textBoxGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGroup_KeyPress);
            // 
            // textBoxPassConfirm
            // 
            this.textBoxPassConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxPassConfirm.Enabled = false;
            this.textBoxPassConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassConfirm.Location = new System.Drawing.Point(189, 87);
            this.textBoxPassConfirm.MaxLength = 50;
            this.textBoxPassConfirm.Name = "textBoxPassConfirm";
            this.textBoxPassConfirm.PasswordChar = '*';
            this.textBoxPassConfirm.Size = new System.Drawing.Size(185, 27);
            this.textBoxPassConfirm.TabIndex = 40;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(116, 120);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(258, 27);
            this.textBoxSurname.TabIndex = 41;
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Фамилия:";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxFirstname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstname.Location = new System.Drawing.Point(116, 153);
            this.textBoxFirstname.MaxLength = 50;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(258, 27);
            this.textBoxFirstname.TabIndex = 43;
            this.textBoxFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(189, 54);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(185, 27);
            this.textBoxPassword.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(6, 9);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 19);
            this.labelLogin.TabIndex = 36;
            this.labelLogin.Text = "Логин:";
            // 
            // checkBoxChangePassword
            // 
            this.checkBoxChangePassword.AutoSize = true;
            this.checkBoxChangePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxChangePassword.Location = new System.Drawing.Point(10, 31);
            this.checkBoxChangePassword.Name = "checkBoxChangePassword";
            this.checkBoxChangePassword.Size = new System.Drawing.Size(140, 23);
            this.checkBoxChangePassword.TabIndex = 50;
            this.checkBoxChangePassword.Text = "Сменить пароль";
            this.checkBoxChangePassword.UseVisualStyleBackColor = true;
            this.checkBoxChangePassword.CheckedChanged += new System.EventHandler(this.checkBoxChangePassword_CheckedChanged);
            // 
            // EditUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 255);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxChangePassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxPassConfirm);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditUserInfoForm";
            this.Text = "OleXis Test: Редактирование пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxPassConfirm;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.CheckBox checkBoxChangePassword;
    }
}