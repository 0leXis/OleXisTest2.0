namespace OleXisTest
{
    partial class ServerSaveDialog
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 106);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 31);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить тест";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(289, 106);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(156, 31);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Название теста:";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxTestName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTestName.Location = new System.Drawing.Point(147, 6);
            this.textBoxTestName.MaxLength = 100;
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(298, 27);
            this.textBoxTestName.TabIndex = 28;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(190, 39);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(255, 27);
            this.comboBoxSubject.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Предмет/Дисциплина:";
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddSubject.Location = new System.Drawing.Point(12, 72);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(430, 28);
            this.buttonAddSubject.TabIndex = 31;
            this.buttonAddSubject.Text = "Добавить предмет/дисциплину";
            this.buttonAddSubject.UseVisualStyleBackColor = false;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // ServerSaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 146);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.textBoxTestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerSaveDialog";
            this.Text = "OleXis Test: Сохранение теста";
            this.Shown += new System.EventHandler(this.ServerSaveDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddSubject;
    }
}