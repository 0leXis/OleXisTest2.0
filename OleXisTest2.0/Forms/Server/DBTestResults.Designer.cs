namespace OleXisTest
{
    partial class DBTestResults
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxTestNameSurname = new System.Windows.Forms.TextBox();
            this.labelTestNameSurname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxUseData = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(16, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(739, 354);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // textBoxTestNameSurname
            // 
            this.textBoxTestNameSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.textBoxTestNameSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTestNameSurname.Location = new System.Drawing.Point(95, 43);
            this.textBoxTestNameSurname.MaxLength = 50;
            this.textBoxTestNameSurname.Name = "textBoxTestNameSurname";
            this.textBoxTestNameSurname.Size = new System.Drawing.Size(220, 27);
            this.textBoxTestNameSurname.TabIndex = 25;
            this.textBoxTestNameSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTestNameSurname_KeyPress);
            this.textBoxTestNameSurname.Leave += new System.EventHandler(this.textBoxTestNameSurname_Leave);
            // 
            // labelTestNameSurname
            // 
            this.labelTestNameSurname.AutoSize = true;
            this.labelTestNameSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestNameSurname.Location = new System.Drawing.Point(12, 46);
            this.labelTestNameSurname.Name = "labelTestNameSurname";
            this.labelTestNameSurname.Size = new System.Drawing.Size(77, 19);
            this.labelTestNameSurname.TabIndex = 24;
            this.labelTestNameSurname.Text = "Фамилия:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 27);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 18, 0, 0, 0, 0);
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // checkBoxUseData
            // 
            this.checkBoxUseData.AutoSize = true;
            this.checkBoxUseData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUseData.Location = new System.Drawing.Point(321, 48);
            this.checkBoxUseData.Name = "checkBoxUseData";
            this.checkBoxUseData.Size = new System.Drawing.Size(229, 23);
            this.checkBoxUseData.TabIndex = 27;
            this.checkBoxUseData.Text = "Использовать фильтр по дате";
            this.checkBoxUseData.UseVisualStyleBackColor = true;
            this.checkBoxUseData.CheckedChanged += new System.EventHandler(this.checkBoxUseData_CheckedChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(222, 9);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 28);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonClearFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilters.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearFilters.Location = new System.Drawing.Point(16, 9);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(200, 28);
            this.buttonClearFilters.TabIndex = 28;
            this.buttonClearFilters.Text = "Сбросить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = false;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // buttonToExcel
            // 
            this.buttonToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonToExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToExcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToExcel.Location = new System.Drawing.Point(428, 9);
            this.buttonToExcel.Name = "buttonToExcel";
            this.buttonToExcel.Size = new System.Drawing.Size(327, 28);
            this.buttonToExcel.TabIndex = 30;
            this.buttonToExcel.Text = "Вывести результаты теста в Excel";
            this.buttonToExcel.UseVisualStyleBackColor = false;
            this.buttonToExcel.Click += new System.EventHandler(this.buttonToExcel_Click);
            // 
            // DBTestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 442);
            this.Controls.Add(this.buttonToExcel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClearFilters);
            this.Controls.Add(this.checkBoxUseData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTestNameSurname);
            this.Controls.Add(this.labelTestNameSurname);
            this.Controls.Add(this.dataGridView);
            this.Name = "DBTestResults";
            this.Text = "OleXis Test: Результаты тестирования";
            this.Shown += new System.EventHandler(this.DBTestResults_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxTestNameSurname;
        private System.Windows.Forms.Label labelTestNameSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxUseData;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonToExcel;
    }
}