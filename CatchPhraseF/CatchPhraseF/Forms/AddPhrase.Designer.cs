namespace CatchPhraseF
{
    partial class AddPhrase
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.acomboBox = new System.Windows.Forms.ComboBox();
            this.abindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.scomboBox = new System.Windows.Forms.ComboBox();
            this.sbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.phrasetextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.abindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автор:";
            // 
            // acomboBox
            // 
            this.acomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acomboBox.DataSource = this.abindingSource;
            this.acomboBox.DisplayMember = "Name";
            this.acomboBox.FormattingEnabled = true;
            this.acomboBox.Location = new System.Drawing.Point(94, 27);
            this.acomboBox.Name = "acomboBox";
            this.acomboBox.Size = new System.Drawing.Size(322, 21);
            this.acomboBox.TabIndex = 1;
            this.acomboBox.SelectedIndexChanged += new System.EventHandler(this.acomboBox_SelectedIndexChanged);
            // 
            // abindingSource
            // 
            this.abindingSource.DataSource = typeof(CatchPhraseF.Model.Author);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Источник:";
            // 
            // scomboBox
            // 
            this.scomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scomboBox.DataSource = this.sbindingSource;
            this.scomboBox.DisplayMember = "Name";
            this.scomboBox.FormattingEnabled = true;
            this.scomboBox.Location = new System.Drawing.Point(93, 57);
            this.scomboBox.Name = "scomboBox";
            this.scomboBox.Size = new System.Drawing.Size(323, 21);
            this.scomboBox.TabIndex = 3;
            // 
            // sbindingSource
            // 
            this.sbindingSource.DataSource = typeof(CatchPhraseF.Model.Source);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фраза:";
            // 
            // phrasetextBox
            // 
            this.phrasetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phrasetextBox.Location = new System.Drawing.Point(93, 115);
            this.phrasetextBox.Multiline = true;
            this.phrasetextBox.Name = "phrasetextBox";
            this.phrasetextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.phrasetextBox.Size = new System.Drawing.Size(323, 164);
            this.phrasetextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(222, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(326, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тема:";
            // 
            // tcomboBox
            // 
            this.tcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcomboBox.FormattingEnabled = true;
            this.tcomboBox.Location = new System.Drawing.Point(94, 87);
            this.tcomboBox.Name = "tcomboBox";
            this.tcomboBox.Size = new System.Drawing.Size(322, 21);
            this.tcomboBox.TabIndex = 9;
            // 
            // AddPhrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 325);
            this.Controls.Add(this.tcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phrasetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acomboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddPhrase";
            this.Text = "AddPhrase";
            this.Load += new System.EventHandler(this.AddPhrase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox acomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phrasetextBox;
        private System.Windows.Forms.BindingSource abindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource sbindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tcomboBox;
    }
}