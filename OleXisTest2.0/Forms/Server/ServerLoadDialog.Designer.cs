namespace OleXisTest
{
    partial class ServerLoadDialog
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(180, 231);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(156, 28);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonLoad.Enabled = false;
            this.buttonLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(16, 231);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(156, 28);
            this.buttonLoad.TabIndex = 27;
            this.buttonLoad.Text = "Загрузить тест";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBoxTests
            // 
            this.listBoxTests.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.ItemHeight = 19;
            this.listBoxTests.Location = new System.Drawing.Point(16, 31);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(320, 194);
            this.listBoxTests.TabIndex = 29;
            this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Список доступных тестов:";
            // 
            // ServerLoadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 267);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTests);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerLoadDialog";
            this.Text = "OleXis Test: Загрузка теста";
            this.Shown += new System.EventHandler(this.ServerLoadDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.Label label2;
    }
}