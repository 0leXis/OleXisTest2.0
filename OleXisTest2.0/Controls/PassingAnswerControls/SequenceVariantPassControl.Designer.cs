﻿namespace OleXisTest
{
    partial class SequenceVariantPassControl
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
            this.listBoxSequence = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxSequence
            // 
            this.listBoxSequence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSequence.FormattingEnabled = true;
            this.listBoxSequence.HorizontalScrollbar = true;
            this.listBoxSequence.ItemHeight = 19;
            this.listBoxSequence.Location = new System.Drawing.Point(7, 22);
            this.listBoxSequence.Name = "listBoxSequence";
            this.listBoxSequence.Size = new System.Drawing.Size(534, 99);
            this.listBoxSequence.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перетаскивайте элементы последовательности";
            // 
            // SequenceVariantPassControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSequence);
            this.Name = "SequenceVariantPassControl";
            this.Size = new System.Drawing.Size(560, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSequence;
        private System.Windows.Forms.Label label1;
    }
}
