namespace OleXisTest
{
    partial class AccordanceVariantPassControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAcc1 = new System.Windows.Forms.ListBox();
            this.listBoxAcc2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Расположите элементы в левом списке \r\nнапротив соответствующих в правом";
            // 
            // listBoxAcc1
            // 
            this.listBoxAcc1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAcc1.FormattingEnabled = true;
            this.listBoxAcc1.HorizontalScrollbar = true;
            this.listBoxAcc1.ItemHeight = 19;
            this.listBoxAcc1.Location = new System.Drawing.Point(7, 43);
            this.listBoxAcc1.Name = "listBoxAcc1";
            this.listBoxAcc1.Size = new System.Drawing.Size(272, 80);
            this.listBoxAcc1.TabIndex = 2;
            // 
            // listBoxAcc2
            // 
            this.listBoxAcc2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAcc2.FormattingEnabled = true;
            this.listBoxAcc2.HorizontalScrollbar = true;
            this.listBoxAcc2.ItemHeight = 19;
            this.listBoxAcc2.Location = new System.Drawing.Point(285, 43);
            this.listBoxAcc2.Name = "listBoxAcc2";
            this.listBoxAcc2.Size = new System.Drawing.Size(270, 80);
            this.listBoxAcc2.TabIndex = 2;
            // 
            // AccordanceVariantPassControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAcc2);
            this.Controls.Add(this.listBoxAcc1);
            this.Name = "AccordanceVariantPassControl";
            this.Size = new System.Drawing.Size(560, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAcc1;
        private System.Windows.Forms.ListBox listBoxAcc2;
    }
}
