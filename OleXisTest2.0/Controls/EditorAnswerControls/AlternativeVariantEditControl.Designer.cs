namespace OleXisTest
{
    partial class AlternativeVariantEditControl
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
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYes.Location = new System.Drawing.Point(7, 23);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(45, 23);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Да";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNo.Location = new System.Drawing.Point(7, 52);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(51, 23);
            this.radioButtonNo.TabIndex = 0;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Нет";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите вариант ответа";
            // 
            // AlternativeVariantEditControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Name = "AlternativeVariantEditControl";
            this.Size = new System.Drawing.Size(299, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Label label1;
    }
}
