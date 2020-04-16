namespace OleXisTest
{
    partial class SingleVariantEditControl
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
            foreach (var component in VariantNumber)
                component.Dispose();
            VariantNumber.Clear();
            foreach (var component in TextVariant)
                component.Dispose();
            TextVariant.Clear();
            foreach (var component in DeleteVariant)
                component.Dispose();
            DeleteVariant.Clear();
            foreach (var component in CorrectVariantSingle)
                component.Dispose();
            CorrectVariantSingle.Clear();

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
            this.buttonAddVariant = new System.Windows.Forms.Button();
            this.panelVariants = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddVariant
            // 
            this.buttonAddVariant.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVariant.Location = new System.Drawing.Point(3, 26);
            this.buttonAddVariant.Name = "buttonAddVariant";
            this.buttonAddVariant.Size = new System.Drawing.Size(191, 31);
            this.buttonAddVariant.TabIndex = 25;
            this.buttonAddVariant.Text = "Добавить вариант";
            this.buttonAddVariant.UseVisualStyleBackColor = true;
            this.buttonAddVariant.Click += new System.EventHandler(this.buttonAddVariant_Click);
            // 
            // panelVariants
            // 
            this.panelVariants.AutoScroll = true;
            this.panelVariants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVariants.Location = new System.Drawing.Point(0, 63);
            this.panelVariants.Name = "panelVariants";
            this.panelVariants.Size = new System.Drawing.Size(707, 104);
            this.panelVariants.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Введите варианты ответа в поля ввода";
            // 
            // SingleVariantEditControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelVariants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddVariant);
            this.Name = "SingleVariantEditControl";
            this.Size = new System.Drawing.Size(707, 167);
            this.SizeChanged += new System.EventHandler(this.SingleVariantEditControl_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVariant;
        private System.Windows.Forms.Panel panelVariants;
        private System.Windows.Forms.Label label1;
    }
}
