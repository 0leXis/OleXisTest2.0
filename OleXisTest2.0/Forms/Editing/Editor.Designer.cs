namespace OleXisTest
{
    partial class Editor
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
            this.tvQuestions = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьССервераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьНаСервереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыТестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCreateSection = new System.Windows.Forms.Button();
            this.buttonDeleteVopr = new System.Windows.Forms.Button();
            this.buttonCreateVopr = new System.Windows.Forms.Button();
            this.buttonDeleteSection = new System.Windows.Forms.Button();
            this.buttonChangeVopr = new System.Windows.Forms.Button();
            this.buttonChangeSection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvQuestions
            // 
            this.tvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvQuestions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvQuestions.Location = new System.Drawing.Point(0, 0);
            this.tvQuestions.Name = "tvQuestions";
            this.tvQuestions.Size = new System.Drawing.Size(162, 411);
            this.tvQuestions.TabIndex = 0;
            this.tvQuestions.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvQuestions_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvQuestions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxAnswers);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxInfo);
            this.splitContainer1.Size = new System.Drawing.Size(814, 411);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxAnswers
            // 
            this.groupBoxAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAnswers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAnswers.Location = new System.Drawing.Point(3, 182);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Size = new System.Drawing.Size(631, 226);
            this.groupBoxAnswers.TabIndex = 16;
            this.groupBoxAnswers.TabStop = false;
            this.groupBoxAnswers.Text = "Ответы";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(631, 173);
            this.groupBoxInfo.TabIndex = 15;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Вопрос";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.тестToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 26);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сохранитьТестToolStripMenuItem,
            this.загрузитьССервераToolStripMenuItem,
            this.сохранитьНаСервереToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.создатьToolStripMenuItem.Text = "Создать тест";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить тест";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьТестToolStripMenuItem
            // 
            this.сохранитьТестToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.сохранитьТестToolStripMenuItem.Enabled = false;
            this.сохранитьТестToolStripMenuItem.Name = "сохранитьТестToolStripMenuItem";
            this.сохранитьТестToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.сохранитьТестToolStripMenuItem.Text = "Сохранить тест";
            this.сохранитьТестToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТестToolStripMenuItem_Click);
            // 
            // загрузитьССервераToolStripMenuItem
            // 
            this.загрузитьССервераToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.загрузитьССервераToolStripMenuItem.Enabled = false;
            this.загрузитьССервераToolStripMenuItem.Name = "загрузитьССервераToolStripMenuItem";
            this.загрузитьССервераToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.загрузитьССервераToolStripMenuItem.Text = "Загрузить с сервера";
            this.загрузитьССервераToolStripMenuItem.Click += new System.EventHandler(this.загрузитьССервераToolStripMenuItem_Click);
            // 
            // сохранитьНаСервереToolStripMenuItem
            // 
            this.сохранитьНаСервереToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.сохранитьНаСервереToolStripMenuItem.Enabled = false;
            this.сохранитьНаСервереToolStripMenuItem.Name = "сохранитьНаСервереToolStripMenuItem";
            this.сохранитьНаСервереToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.сохранитьНаСервереToolStripMenuItem.Text = "Сохранить на сервере";
            this.сохранитьНаСервереToolStripMenuItem.Click += new System.EventHandler(this.сохранитьНаСервереToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьВопросToolStripMenuItem,
            this.редактироватьВопросToolStripMenuItem,
            this.создатьРазделToolStripMenuItem,
            this.редактироватьРазделToolStripMenuItem,
            this.параметрыТестаToolStripMenuItem});
            this.тестToolStripMenuItem.Enabled = false;
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // создатьВопросToolStripMenuItem
            // 
            this.создатьВопросToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.создатьВопросToolStripMenuItem.Name = "создатьВопросToolStripMenuItem";
            this.создатьВопросToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.создатьВопросToolStripMenuItem.Text = "Создать вопрос";
            this.создатьВопросToolStripMenuItem.Click += new System.EventHandler(this.создатьВопросToolStripMenuItem_Click);
            // 
            // редактироватьВопросToolStripMenuItem
            // 
            this.редактироватьВопросToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.редактироватьВопросToolStripMenuItem.Name = "редактироватьВопросToolStripMenuItem";
            this.редактироватьВопросToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.редактироватьВопросToolStripMenuItem.Text = "Редактировать вопрос";
            this.редактироватьВопросToolStripMenuItem.Click += new System.EventHandler(this.редактироватьВопросToolStripMenuItem_Click);
            // 
            // создатьРазделToolStripMenuItem
            // 
            this.создатьРазделToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.создатьРазделToolStripMenuItem.Name = "создатьРазделToolStripMenuItem";
            this.создатьРазделToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.создатьРазделToolStripMenuItem.Text = "Создать раздел";
            this.создатьРазделToolStripMenuItem.Click += new System.EventHandler(this.создатьРазделToolStripMenuItem_Click);
            // 
            // редактироватьРазделToolStripMenuItem
            // 
            this.редактироватьРазделToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.редактироватьРазделToolStripMenuItem.Name = "редактироватьРазделToolStripMenuItem";
            this.редактироватьРазделToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.редактироватьРазделToolStripMenuItem.Text = "Редактировать раздел";
            this.редактироватьРазделToolStripMenuItem.Click += new System.EventHandler(this.редактироватьРазделToolStripMenuItem_Click);
            // 
            // параметрыТестаToolStripMenuItem
            // 
            this.параметрыТестаToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.параметрыТестаToolStripMenuItem.Name = "параметрыТестаToolStripMenuItem";
            this.параметрыТестаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.параметрыТестаToolStripMenuItem.Text = "Параметры теста";
            this.параметрыТестаToolStripMenuItem.Click += new System.EventHandler(this.параметрыТестаToolStripMenuItem_Click);
            // 
            // buttonCreateSection
            // 
            this.buttonCreateSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonCreateSection.Enabled = false;
            this.buttonCreateSection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonCreateSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateSection.Location = new System.Drawing.Point(2, 478);
            this.buttonCreateSection.Name = "buttonCreateSection";
            this.buttonCreateSection.Size = new System.Drawing.Size(156, 28);
            this.buttonCreateSection.TabIndex = 25;
            this.buttonCreateSection.Text = "Создать раздел";
            this.buttonCreateSection.UseVisualStyleBackColor = false;
            this.buttonCreateSection.Click += new System.EventHandler(this.buttonCreateSection_Click);
            // 
            // buttonDeleteVopr
            // 
            this.buttonDeleteVopr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonDeleteVopr.Enabled = false;
            this.buttonDeleteVopr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonDeleteVopr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteVopr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteVopr.Location = new System.Drawing.Point(163, 444);
            this.buttonDeleteVopr.Name = "buttonDeleteVopr";
            this.buttonDeleteVopr.Size = new System.Drawing.Size(156, 28);
            this.buttonDeleteVopr.TabIndex = 24;
            this.buttonDeleteVopr.Text = "Удалить вопрос";
            this.buttonDeleteVopr.UseVisualStyleBackColor = false;
            this.buttonDeleteVopr.Click += new System.EventHandler(this.buttonDeleteVopr_Click);
            // 
            // buttonCreateVopr
            // 
            this.buttonCreateVopr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonCreateVopr.Enabled = false;
            this.buttonCreateVopr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonCreateVopr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateVopr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateVopr.Location = new System.Drawing.Point(2, 444);
            this.buttonCreateVopr.Name = "buttonCreateVopr";
            this.buttonCreateVopr.Size = new System.Drawing.Size(156, 28);
            this.buttonCreateVopr.TabIndex = 23;
            this.buttonCreateVopr.Text = "Создать вопрос";
            this.buttonCreateVopr.UseVisualStyleBackColor = false;
            this.buttonCreateVopr.Click += new System.EventHandler(this.buttonCreateVopr_Click);
            // 
            // buttonDeleteSection
            // 
            this.buttonDeleteSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonDeleteSection.Enabled = false;
            this.buttonDeleteSection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonDeleteSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteSection.Location = new System.Drawing.Point(163, 478);
            this.buttonDeleteSection.Name = "buttonDeleteSection";
            this.buttonDeleteSection.Size = new System.Drawing.Size(156, 28);
            this.buttonDeleteSection.TabIndex = 22;
            this.buttonDeleteSection.Text = "Удалить раздел";
            this.buttonDeleteSection.UseVisualStyleBackColor = false;
            this.buttonDeleteSection.Click += new System.EventHandler(this.buttonDeleteSection_Click);
            // 
            // buttonChangeVopr
            // 
            this.buttonChangeVopr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonChangeVopr.Enabled = false;
            this.buttonChangeVopr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonChangeVopr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeVopr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeVopr.Location = new System.Drawing.Point(325, 444);
            this.buttonChangeVopr.Name = "buttonChangeVopr";
            this.buttonChangeVopr.Size = new System.Drawing.Size(208, 28);
            this.buttonChangeVopr.TabIndex = 21;
            this.buttonChangeVopr.Text = "Редактировать вопрос";
            this.buttonChangeVopr.UseVisualStyleBackColor = false;
            this.buttonChangeVopr.Click += new System.EventHandler(this.buttonChangeVopr_Click);
            // 
            // buttonChangeSection
            // 
            this.buttonChangeSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(101)))));
            this.buttonChangeSection.Enabled = false;
            this.buttonChangeSection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.buttonChangeSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeSection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeSection.Location = new System.Drawing.Point(325, 478);
            this.buttonChangeSection.Name = "buttonChangeSection";
            this.buttonChangeSection.Size = new System.Drawing.Size(208, 28);
            this.buttonChangeSection.TabIndex = 21;
            this.buttonChangeSection.Text = "Редактировать раздел";
            this.buttonChangeSection.UseVisualStyleBackColor = false;
            this.buttonChangeSection.Click += new System.EventHandler(this.buttonChangeSection_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 514);
            this.Controls.Add(this.buttonCreateSection);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonCreateVopr);
            this.Controls.Add(this.buttonDeleteVopr);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonChangeSection);
            this.Controls.Add(this.buttonChangeVopr);
            this.Controls.Add(this.buttonDeleteSection);
            this.Name = "Editor";
            this.Text = "OleXis Test: Редактор тестов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvQuestions;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьССервераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНаСервереToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыТестаToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreateSection;
        private System.Windows.Forms.Button buttonDeleteVopr;
        private System.Windows.Forms.Button buttonCreateVopr;
        private System.Windows.Forms.Button buttonDeleteSection;
        private System.Windows.Forms.Button buttonChangeVopr;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Button buttonChangeSection;
    }
}