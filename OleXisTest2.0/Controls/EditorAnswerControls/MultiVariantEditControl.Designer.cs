namespace OleXisTest
{
    partial class MultiVariantEditControl
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
            foreach (var component in CorrectVariantMulti)
                component.Dispose();
            CorrectVariantMulti.Clear();

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
            this.buttonAddVariant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonAddVariant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonAddVariant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVariant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddVariant.Location = new System.Drawing.Point(3, 22);
            this.buttonAddVariant.Name = "buttonAddVariant";
            this.buttonAddVariant.Size = new System.Drawing.Size(191, 28);
            this.buttonAddVariant.TabIndex = 26;
            this.buttonAddVariant.Text = "Добавить вариант";
            this.buttonAddVariant.UseVisualStyleBackColor = false;
            this.buttonAddVariant.Click += new System.EventHandler(this.buttonAddVariant_Click);
            // 
            // panelVariants
            // 
            this.panelVariants.AutoScroll = true;
            this.panelVariants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVariants.Location = new System.Drawing.Point(0, 59);
            this.panelVariants.Name = "panelVariants";
            this.panelVariants.Size = new System.Drawing.Size(581, 153);
            this.panelVariants.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Введите варианты ответа в поля ввода";
            // 
            // MultiVariantEditControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelVariants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddVariant);
            this.Name = "MultiVariantEditControl";
            this.Size = new System.Drawing.Size(581, 212);
            this.SizeChanged += new System.EventHandler(this.MultiVariantEditControl_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVariant;
        private System.Windows.Forms.Panel panelVariants;
        private System.Windows.Forms.Label label1;
    }
}
