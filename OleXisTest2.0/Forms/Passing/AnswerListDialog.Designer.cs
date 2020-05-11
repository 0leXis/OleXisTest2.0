﻿namespace OleXisTest
{
    partial class AnswerListDialog
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
            foreach (var component in Ansvers)
                if(component != null)
                    component.Dispose();
            Ansvers.Clear();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(205, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Правильный ответ, который не был выбран";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(205, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Был выбран неправильный ответ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(205, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Был выбран правильный ответ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Условные обозначения:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(3, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(776, 255);
            this.panel.TabIndex = 16;
            // 
            // AnswerListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel);
            this.Name = "AnswerListDialog";
            this.Text = "AnswerListDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
    }
}