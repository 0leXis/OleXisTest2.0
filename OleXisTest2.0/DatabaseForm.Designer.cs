namespace OleXisTest
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Enabled = false;
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTeacher.Location = new System.Drawing.Point(12, 12);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(222, 29);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Добавить преподавателя";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Enabled = false;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStudent.Location = new System.Drawing.Point(240, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(222, 29);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Добавить учащегося";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Enabled = false;
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddGroup.Location = new System.Drawing.Point(468, 12);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(222, 29);
            this.btnAddGroup.TabIndex = 3;
            this.btnAddGroup.Text = "Добавить группу/класс";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Enabled = false;
            this.btnAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSubject.Location = new System.Drawing.Point(696, 12);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(222, 29);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Добавить предмет";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущие данные (редактирование учетных записей доступно только администратору):";
            // 
            // comboBoxData
            // 
            this.comboBoxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxData.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "Все тесты",
            "Мои тесты",
            "Учетные записи"});
            this.comboBoxData.Location = new System.Drawing.Point(662, 44);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(256, 31);
            this.comboBoxData.TabIndex = 6;
            this.comboBoxData.SelectedIndexChanged += new System.EventHandler(this.comboBoxData_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(903, 389);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // comboBoxSubjectRole
            // 
            this.comboBoxSubjectRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjectRole.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSubjectRole.FormattingEnabled = true;
            this.comboBoxSubjectRole.Items.AddRange(new object[] {
            "Мои тесты",
            "Все тесты",
            "Учетные записи"});
            this.comboBoxSubjectRole.Location = new System.Drawing.Point(608, 81);
            this.comboBoxSubjectRole.Name = "comboBoxSubjectRole";
            this.comboBoxSubjectRole.Size = new System.Drawing.Size(310, 31);
            this.comboBoxSubjectRole.TabIndex = 8;
            this.comboBoxSubjectRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubjectRole_SelectedIndexChanged);
            // 
            // labelSubjectRole
            // 
            this.labelSubjectRole.AutoSize = true;
            this.labelSubjectRole.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubjectRole.Location = new System.Drawing.Point(429, 84);
            this.labelSubjectRole.Name = "labelSubjectRole";
            this.labelSubjectRole.Size = new System.Drawing.Size(173, 23);
            this.labelSubjectRole.TabIndex = 9;
            this.labelSubjectRole.Text = "Дисциплина/Предмет:";
            // 
            // labelTestNameSurname
            // 
            this.labelTestNameSurname.AutoSize = true;
            this.labelTestNameSurname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestNameSurname.Location = new System.Drawing.Point(12, 84);
            this.labelTestNameSurname.Name = "labelTestNameSurname";
            this.labelTestNameSurname.Size = new System.Drawing.Size(85, 23);
            this.labelTestNameSurname.TabIndex = 10;
            this.labelTestNameSurname.Text = "Название:";
            // 
            // textBoxTestNameSurname
            // 
            this.textBoxTestNameSurname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestNameSurname.Location = new System.Drawing.Point(103, 81);
            this.textBoxTestNameSurname.Name = "textBoxTestNameSurname";
            this.textBoxTestNameSurname.Size = new System.Drawing.Size(320, 29);
            this.textBoxTestNameSurname.TabIndex = 23;
            this.textBoxTestNameSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTestNameSurname_KeyPress);
            this.textBoxTestNameSurname.Leave += new System.EventHandler(this.textBoxTestNameSurname_Leave);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDate.Location = new System.Drawing.Point(473, 116);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(183, 27);
            this.checkBoxDate.TabIndex = 24;
            this.checkBoxDate.Text = "Сортировать по дате";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearFilters.Location = new System.Drawing.Point(12, 116);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(222, 29);
            this.buttonClearFilters.TabIndex = 25;
            this.buttonClearFilters.Text = "Сбросить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(240, 116);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(222, 29);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 552);
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
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
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
    }
}