namespace OleXisTest
{
    partial class SequenceVariantEditControl
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
            foreach (var component in SequenceText)
                component.Dispose();
            SequenceText.Clear();
            foreach (var component in DeleteVariant)
                component.Dispose();
            DeleteVariant.Clear();
            foreach (var component in DownVariant)
                component.Dispose();
            DownVariant.Clear();
            foreach (var component in UpVariant)
                component.Dispose();
            UpVariant.Clear();

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
            this.label1 = new System.Windows.Forms.Label();
            this.panelVariants = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonAddVariant
            // 
            this.buttonAddVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddVariant.Location = new System.Drawing.Point(3, 31);
            this.buttonAddVariant.Name = "buttonAddVariant";
            this.buttonAddVariant.Size = new System.Drawing.Size(336, 31);
            this.buttonAddVariant.TabIndex = 27;
            this.buttonAddVariant.Text = "Добавить элемент последовательности";
            this.buttonAddVariant.UseVisualStyleBackColor = true;
            this.buttonAddVariant.Click += new System.EventHandler(this.buttonAddVariant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введите элементы последовательности в поля ввода";
            // 
            // panelVariants
            // 
            this.panelVariants.AutoScroll = true;
            this.panelVariants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVariants.Location = new System.Drawing.Point(0, 68);
            this.panelVariants.Name = "panelVariants";
            this.panelVariants.Size = new System.Drawing.Size(598, 128);
            this.panelVariants.TabIndex = 29;
            // 
            // SequenceVariantEditControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelVariants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddVariant);
            this.Name = "SequenceVariantEditControl";
            this.Size = new System.Drawing.Size(598, 196);
            this.SizeChanged += new System.EventHandler(this.SequenceVariantEditControl_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVariant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVariants;
    }
}
