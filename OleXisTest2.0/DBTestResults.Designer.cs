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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxTestNameSurname = new System.Windows.Forms.TextBox();
            this.labelTestNameSurname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxUseData = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(783, 354);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // textBoxTestNameSurname
            // 
            this.textBoxTestNameSurname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestNameSurname.Location = new System.Drawing.Point(99, 6);
            this.textBoxTestNameSurname.Name = "textBoxTestNameSurname";
            this.textBoxTestNameSurname.Size = new System.Drawing.Size(241, 29);
            this.textBoxTestNameSurname.TabIndex = 25;
            this.textBoxTestNameSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTestNameSurname_KeyPress);
            this.textBoxTestNameSurname.Leave += new System.EventHandler(this.textBoxTestNameSurname_Leave);
            // 
            // labelTestNameSurname
            // 
            this.labelTestNameSurname.AutoSize = true;
            this.labelTestNameSurname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestNameSurname.Location = new System.Drawing.Point(12, 9);
            this.labelTestNameSurname.Name = "labelTestNameSurname";
            this.labelTestNameSurname.Size = new System.Drawing.Size(81, 23);
            this.labelTestNameSurname.TabIndex = 24;
            this.labelTestNameSurname.Text = "Фамилия:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(599, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 29);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 18, 0, 0, 0, 0);
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // checkBoxUseData
            // 
            this.checkBoxUseData.AutoSize = true;
            this.checkBoxUseData.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUseData.Location = new System.Drawing.Point(346, 8);
            this.checkBoxUseData.Name = "checkBoxUseData";
            this.checkBoxUseData.Size = new System.Drawing.Size(248, 27);
            this.checkBoxUseData.TabIndex = 27;
            this.checkBoxUseData.Text = "Использовать фильтр по дате";
            this.checkBoxUseData.UseVisualStyleBackColor = true;
            this.checkBoxUseData.CheckedChanged += new System.EventHandler(this.checkBoxUseData_CheckedChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(244, 41);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(222, 29);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearFilters.Location = new System.Drawing.Point(16, 41);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(222, 29);
            this.buttonClearFilters.TabIndex = 28;
            this.buttonClearFilters.Text = "Сбросить фильтры";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // DBTestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 442);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClearFilters);
            this.Controls.Add(this.checkBoxUseData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTestNameSurname);
            this.Controls.Add(this.labelTestNameSurname);
            this.Controls.Add(this.dataGridView);
            this.Name = "DBTestResults";
            this.Text = "DBTestResults";
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
    }
}