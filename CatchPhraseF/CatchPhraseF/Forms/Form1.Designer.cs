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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИсточникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФразуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.источникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.critcomboBox = new System.Windows.Forms.ComboBox();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.respanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАвтораToolStripMenuItem,
            this.добавитьИсточникToolStripMenuItem,
            this.добавитьФразуToolStripMenuItem,
            this.добавитьТемыToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.редактированиеToolStripMenuItem.Text = "Добавление";
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
            // добавитьТемыToolStripMenuItem
            // 
            this.добавитьТемыToolStripMenuItem.Name = "добавитьТемыToolStripMenuItem";
            this.добавитьТемыToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.добавитьТемыToolStripMenuItem.Text = "Добавить темы";
            this.добавитьТемыToolStripMenuItem.Click += new System.EventHandler(this.добавитьТемыToolStripMenuItem_Click);
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
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // источникиToolStripMenuItem
            // 
            this.источникиToolStripMenuItem.Name = "источникиToolStripMenuItem";
            this.источникиToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
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
            this.critcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.critcomboBox.FormattingEnabled = true;
            this.critcomboBox.Location = new System.Drawing.Point(112, 36);
            this.critcomboBox.Name = "critcomboBox";
            this.critcomboBox.Size = new System.Drawing.Size(142, 21);
            this.critcomboBox.TabIndex = 2;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtextBox.Location = new System.Drawing.Point(15, 66);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(597, 20);
            this.searchtextBox.TabIndex = 3;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // respanel
            // 
            this.respanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.respanel.AutoScroll = true;
            this.respanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.respanel.Location = new System.Drawing.Point(15, 92);
            this.respanel.Name = "respanel";
            this.respanel.Size = new System.Drawing.Size(598, 359);
            this.respanel.TabIndex = 5;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(129, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 463);
            this.Controls.Add(this.respanel);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.critcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem добавитьТемыToolStripMenuItem;
        private System.Windows.Forms.Panel respanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
    }
}

