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
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьССервераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьНаСервереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.создатьРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.tvQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvQuestions.Location = new System.Drawing.Point(0, 0);
            this.tvQuestions.Name = "tvQuestions";
            this.tvQuestions.Size = new System.Drawing.Size(162, 411);
            this.tvQuestions.TabIndex = 0;
            this.tvQuestions.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvQuestions_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
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
            this.groupBoxAnswers.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnswers.Location = new System.Drawing.Point(3, 182);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Size = new System.Drawing.Size(631, 226);
            this.groupBoxAnswers.TabIndex = 16;
            this.groupBoxAnswers.TabStop = false;
            this.groupBoxAnswers.Text = "Ответы";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(631, 173);
            this.groupBoxInfo.TabIndex = 15;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Вопрос";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.тестToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.toolStripMenuItem3,
            this.загрузитьToolStripMenuItem,
            this.сохранитьТестToolStripMenuItem,
            this.загрузитьССервераToolStripMenuItem,
            this.сохранитьНаСервереToolStripMenuItem,
            this.toolStripMenuItem4,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.создатьToolStripMenuItem.Text = "Создать тест";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 6);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить тест";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьТестToolStripMenuItem
            // 
            this.сохранитьТестToolStripMenuItem.Enabled = false;
            this.сохранитьТестToolStripMenuItem.Name = "сохранитьТестToolStripMenuItem";
            this.сохранитьТестToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сохранитьТестToolStripMenuItem.Text = "Сохранить тест";
            this.сохранитьТестToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТестToolStripMenuItem_Click);
            // 
            // загрузитьССервераToolStripMenuItem
            // 
            this.загрузитьССервераToolStripMenuItem.Enabled = false;
            this.загрузитьССервераToolStripMenuItem.Name = "загрузитьССервераToolStripMenuItem";
            this.загрузитьССервераToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.загрузитьССервераToolStripMenuItem.Text = "Загрузить с сервера";
            this.загрузитьССервераToolStripMenuItem.Click += new System.EventHandler(this.загрузитьССервераToolStripMenuItem_Click);
            // 
            // сохранитьНаСервереToolStripMenuItem
            // 
            this.сохранитьНаСервереToolStripMenuItem.Enabled = false;
            this.сохранитьНаСервереToolStripMenuItem.Name = "сохранитьНаСервереToolStripMenuItem";
            this.сохранитьНаСервереToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сохранитьНаСервереToolStripMenuItem.Text = "Сохранить на сервере";
            this.сохранитьНаСервереToolStripMenuItem.Click += new System.EventHandler(this.сохранитьНаСервереToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьВопросToolStripMenuItem,
            this.редактироватьВопросToolStripMenuItem,
            this.toolStripMenuItem2,
            this.создатьРазделToolStripMenuItem,
            this.редактироватьРазделToolStripMenuItem,
            this.toolStripMenuItem1,
            this.параметрыТестаToolStripMenuItem});
            this.тестToolStripMenuItem.Enabled = false;
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // создатьВопросToolStripMenuItem
            // 
            this.создатьВопросToolStripMenuItem.Name = "создатьВопросToolStripMenuItem";
            this.создатьВопросToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.создатьВопросToolStripMenuItem.Text = "Создать вопрос";
            this.создатьВопросToolStripMenuItem.Click += new System.EventHandler(this.создатьВопросToolStripMenuItem_Click);
            // 
            // редактироватьВопросToolStripMenuItem
            // 
            this.редактироватьВопросToolStripMenuItem.Name = "редактироватьВопросToolStripMenuItem";
            this.редактироватьВопросToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.редактироватьВопросToolStripMenuItem.Text = "Редактировать вопрос";
            this.редактироватьВопросToolStripMenuItem.Click += new System.EventHandler(this.редактироватьВопросToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 6);
            // 
            // создатьРазделToolStripMenuItem
            // 
            this.создатьРазделToolStripMenuItem.Name = "создатьРазделToolStripMenuItem";
            this.создатьРазделToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.создатьРазделToolStripMenuItem.Text = "Создать раздел";
            this.создатьРазделToolStripMenuItem.Click += new System.EventHandler(this.создатьРазделToolStripMenuItem_Click);
            // 
            // редактироватьРазделToolStripMenuItem
            // 
            this.редактироватьРазделToolStripMenuItem.Name = "редактироватьРазделToolStripMenuItem";
            this.редактироватьРазделToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.редактироватьРазделToolStripMenuItem.Text = "Редактировать раздел";
            this.редактироватьРазделToolStripMenuItem.Click += new System.EventHandler(this.редактироватьРазделToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // параметрыТестаToolStripMenuItem
            // 
            this.параметрыТестаToolStripMenuItem.Name = "параметрыТестаToolStripMenuItem";
            this.параметрыТестаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.параметрыТестаToolStripMenuItem.Text = "Параметры теста";
            this.параметрыТестаToolStripMenuItem.Click += new System.EventHandler(this.параметрыТестаToolStripMenuItem_Click);
            // 
            // buttonCreateSection
            // 
            this.buttonCreateSection.Enabled = false;
            this.buttonCreateSection.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSection.Location = new System.Drawing.Point(2, 485);
            this.buttonCreateSection.Name = "buttonCreateSection";
            this.buttonCreateSection.Size = new System.Drawing.Size(156, 31);
            this.buttonCreateSection.TabIndex = 25;
            this.buttonCreateSection.Text = "Создать раздел";
            this.buttonCreateSection.UseVisualStyleBackColor = true;
            this.buttonCreateSection.Click += new System.EventHandler(this.buttonCreateSection_Click);
            // 
            // buttonDeleteVopr
            // 
            this.buttonDeleteVopr.Enabled = false;
            this.buttonDeleteVopr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteVopr.Location = new System.Drawing.Point(163, 444);
            this.buttonDeleteVopr.Name = "buttonDeleteVopr";
            this.buttonDeleteVopr.Size = new System.Drawing.Size(156, 31);
            this.buttonDeleteVopr.TabIndex = 24;
            this.buttonDeleteVopr.Text = "Удалить вопрос";
            this.buttonDeleteVopr.UseVisualStyleBackColor = true;
            this.buttonDeleteVopr.Click += new System.EventHandler(this.buttonDeleteVopr_Click);
            // 
            // buttonCreateVopr
            // 
            this.buttonCreateVopr.Enabled = false;
            this.buttonCreateVopr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateVopr.Location = new System.Drawing.Point(2, 444);
            this.buttonCreateVopr.Name = "buttonCreateVopr";
            this.buttonCreateVopr.Size = new System.Drawing.Size(156, 31);
            this.buttonCreateVopr.TabIndex = 23;
            this.buttonCreateVopr.Text = "Создать вопрос";
            this.buttonCreateVopr.UseVisualStyleBackColor = true;
            this.buttonCreateVopr.Click += new System.EventHandler(this.buttonCreateVopr_Click);
            // 
            // buttonDeleteSection
            // 
            this.buttonDeleteSection.Enabled = false;
            this.buttonDeleteSection.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSection.Location = new System.Drawing.Point(163, 485);
            this.buttonDeleteSection.Name = "buttonDeleteSection";
            this.buttonDeleteSection.Size = new System.Drawing.Size(156, 31);
            this.buttonDeleteSection.TabIndex = 22;
            this.buttonDeleteSection.Text = "Удалить раздел";
            this.buttonDeleteSection.UseVisualStyleBackColor = true;
            this.buttonDeleteSection.Click += new System.EventHandler(this.buttonDeleteSection_Click);
            // 
            // buttonChangeVopr
            // 
            this.buttonChangeVopr.Enabled = false;
            this.buttonChangeVopr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeVopr.Location = new System.Drawing.Point(325, 444);
            this.buttonChangeVopr.Name = "buttonChangeVopr";
            this.buttonChangeVopr.Size = new System.Drawing.Size(208, 31);
            this.buttonChangeVopr.TabIndex = 21;
            this.buttonChangeVopr.Text = "Редактировать вопрос";
            this.buttonChangeVopr.UseVisualStyleBackColor = true;
            this.buttonChangeVopr.Click += new System.EventHandler(this.buttonChangeVopr_Click);
            // 
            // buttonChangeSection
            // 
            this.buttonChangeSection.Enabled = false;
            this.buttonChangeSection.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSection.Location = new System.Drawing.Point(325, 485);
            this.buttonChangeSection.Name = "buttonChangeSection";
            this.buttonChangeSection.Size = new System.Drawing.Size(208, 31);
            this.buttonChangeSection.TabIndex = 21;
            this.buttonChangeSection.Text = "Редактировать раздел";
            this.buttonChangeSection.UseVisualStyleBackColor = true;
            this.buttonChangeSection.Click += new System.EventHandler(this.buttonChangeSection_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.buttonCreateSection);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonCreateVopr);
            this.Controls.Add(this.buttonDeleteVopr);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonChangeSection);
            this.Controls.Add(this.buttonChangeVopr);
            this.Controls.Add(this.buttonDeleteSection);
            this.Name = "Editor";
            this.Text = "Editor";
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
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьССервераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНаСервереToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem создатьРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
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