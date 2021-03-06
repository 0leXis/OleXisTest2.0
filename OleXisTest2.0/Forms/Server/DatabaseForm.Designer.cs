﻿namespace OleXisTest
{
    partial class DatabaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxSubjectRole = new System.Windows.Forms.ComboBox();
            this.labelSubjectRole = new System.Windows.Forms.Label();
            this.labelTestNameSurname = new System.Windows.Forms.Label();
            this.textBoxTestNameSurname = new System.Windows.Forms.TextBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.btnAddTeacher.Enabled = false;
            this.btnAddTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTeacher.Location = new System.Drawing.Point(12, 12);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(200, 28);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Добавить преподавателя";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.btnAddStudent.Enabled = false;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStudent.Location = new System.Drawing.Point(228, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 28);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Добавить учащегося";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.btnAddGroup.Enabled = false;
            this.btnAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddGroup.Location = new System.Drawing.Point(447, 12);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(200, 28);
            this.btnAddGroup.TabIndex = 3;
            this.btnAddGroup.Text = "Добавить группу/класс";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.btnAddSubject.Enabled = false;
            this.btnAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSubject.Location = new System.Drawing.Point(668, 12);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(200, 28);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Добавить предмет";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущие данные (редактирование учетных записей доступно только администратору):";
            // 
            // comboBoxData
            // 
            this.comboBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.comboBoxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "Все тесты",
            "Мои тесты",
            "Учетные записи"});
            this.comboBoxData.Location = new System.Drawing.Point(626, 46);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(242, 27);
            this.comboBoxData.TabIndex = 6;
            this.comboBoxData.SelectedIndexChanged += new System.EventHandler(this.comboBoxData_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(856, 389);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // comboBoxSubjectRole
            // 
            this.comboBoxSubjectRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.comboBoxSubjectRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjectRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubjectRole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubjectRole.FormattingEnabled = true;
            this.comboBoxSubjectRole.Items.AddRange(new object[] {
            "Мои тесты",
            "Все тесты",
            "Учетные записи"});
            this.comboBoxSubjectRole.Location = new System.Drawing.Point(599, 76);
            this.comboBoxSubjectRole.Name = "comboBoxSubjectRole";
            this.comboBoxSubjectRole.Size = new System.Drawing.Size(269, 27);
            this.comboBoxSubjectRole.TabIndex = 8;
            this.comboBoxSubjectRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubjectRole_SelectedIndexChanged);
            // 
            // labelSubjectRole
            // 
            this.labelSubjectRole.AutoSize = true;
            this.labelSubjectRole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubjectRole.Location = new System.Drawing.Point(424, 79);
            this.labelSubjectRole.Name = "labelSubjectRole";
            this.labelSubjectRole.Size = new System.Drawing.Size(165, 19);
            this.labelSubjectRole.TabIndex = 9;
            this.labelSubjectRole.Text = "Дисциплина/Предмет:";
            // 
            // labelTestNameSurname
            // 
            this.labelTestNameSurname.AutoSize = true;
            this.labelTestNameSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestNameSurname.Location = new System.Drawing.Point(12, 79);
            this.labelTestNameSurname.Name = "labelTestNameSurname";
            this.labelTestNameSurname.Size = new System.Drawing.Size(80, 19);
            this.labelTestNameSurname.TabIndex = 10;
            this.labelTestNameSurname.Text = "Название:";
            // 
            // textBoxTestNameSurname
            // 
            this.textBoxTestNameSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxTestNameSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTestNameSurname.Location = new System.Drawing.Point(98, 76);
            this.textBoxTestNameSurname.MaxLength = 100;
            this.textBoxTestNameSurname.Name = "textBoxTestNameSurname";
            this.textBoxTestNameSurname.Size = new System.Drawing.Size(320, 27);
            this.textBoxTestNameSurname.TabIndex = 23;
            this.textBoxTestNameSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTestNameSurname_KeyPress);
            this.textBoxTestNameSurname.Leave += new System.EventHandler(this.textBoxTestNameSurname_Leave);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDate.Location = new System.Drawing.Point(424, 113);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(169, 23);
            this.checkBoxDate.TabIndex = 24;
            this.checkBoxDate.Text = "Сортировать по дате";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonClearFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilters.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearFilters.Location = new System.Drawing.Point(12, 109);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(200, 28);
            this.buttonClearFilters.TabIndex = 25;
            this.buttonClearFilters.Text = "Сбросить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = false;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(218, 109);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 28);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(599, 109);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(269, 28);
            this.buttonHelp.TabIndex = 27;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 552);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClearFilters);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.textBoxTestNameSurname);
            this.Controls.Add(this.labelTestNameSurname);
            this.Controls.Add(this.labelSubjectRole);
            this.Controls.Add(this.comboBoxSubjectRole);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnAddTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseForm";
            this.Text = "OleXis Test: Управление информацией БД";
            this.Shown += new System.EventHandler(this.DatabaseForm_Shown);
            this.Click += new System.EventHandler(this.DatabaseForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.ComboBox comboBoxSubjectRole;
        private System.Windows.Forms.Label labelSubjectRole;
        private System.Windows.Forms.Label labelTestNameSurname;
        private System.Windows.Forms.TextBox textBoxTestNameSurname;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonHelp;
    }
}