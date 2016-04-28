namespace CatchPhraseF
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИсточникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФразуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.источникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.critcomboBox = new System.Windows.Forms.ComboBox();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.restextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАвтораToolStripMenuItem,
            this.добавитьИсточникToolStripMenuItem,
            this.добавитьФразуToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавитьАвтораToolStripMenuItem
            // 
            this.добавитьАвтораToolStripMenuItem.Name = "добавитьАвтораToolStripMenuItem";
            this.добавитьАвтораToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.добавитьАвтораToolStripMenuItem.Text = "Добавить автора";
            this.добавитьАвтораToolStripMenuItem.Click += new System.EventHandler(this.добавитьАвтораToolStripMenuItem_Click);
            // 
            // добавитьИсточникToolStripMenuItem
            // 
            this.добавитьИсточникToolStripMenuItem.Name = "добавитьИсточникToolStripMenuItem";
            this.добавитьИсточникToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.добавитьИсточникToolStripMenuItem.Text = "Добавить источник";
            this.добавитьИсточникToolStripMenuItem.Click += new System.EventHandler(this.добавитьИсточникToolStripMenuItem_Click);
            // 
            // добавитьФразуToolStripMenuItem
            // 
            this.добавитьФразуToolStripMenuItem.Name = "добавитьФразуToolStripMenuItem";
            this.добавитьФразуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.добавитьФразуToolStripMenuItem.Text = "Добавить фразу";
            this.добавитьФразуToolStripMenuItem.Click += new System.EventHandler(this.добавитьФразуToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторыToolStripMenuItem,
            this.источникиToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // источникиToolStripMenuItem
            // 
            this.источникиToolStripMenuItem.Name = "источникиToolStripMenuItem";
            this.источникиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.источникиToolStripMenuItem.Text = "Источники";
            this.источникиToolStripMenuItem.Click += new System.EventHandler(this.источникиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Критерий поиска";
            // 
            // critcomboBox
            // 
            this.critcomboBox.FormattingEnabled = true;
            this.critcomboBox.Location = new System.Drawing.Point(112, 36);
            this.critcomboBox.Name = "critcomboBox";
            this.critcomboBox.Size = new System.Drawing.Size(142, 21);
            this.critcomboBox.TabIndex = 2;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(15, 66);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(483, 20);
            this.searchtextBox.TabIndex = 3;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(504, 63);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(108, 23);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.Text = "Поиск";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // restextBox
            // 
            this.restextBox.Location = new System.Drawing.Point(15, 93);
            this.restextBox.Multiline = true;
            this.restextBox.Name = "restextBox";
            this.restextBox.ReadOnly = true;
            this.restextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.restextBox.Size = new System.Drawing.Size(597, 358);
            this.restextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 463);
            this.Controls.Add(this.restextBox);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.critcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИсточникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьФразуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem источникиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox critcomboBox;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox restextBox;
    }
}

