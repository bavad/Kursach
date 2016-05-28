namespace CatchPhraseF
{
    partial class SourcesInfo
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.sbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ntextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ytextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.atextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inftextBox = new System.Windows.Forms.TextBox();
            this.delbutton = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИСТОЧНИКИ";
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox.DataSource = this.sbindingSource;
            this.listBox.DisplayMember = "Name";
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 29);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(124, 329);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // sbindingSource
            // 
            this.sbindingSource.DataSource = typeof(CatchPhraseF.Model.Source);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "НАЗВАНИЕ";
            // 
            // ntextBox
            // 
            this.ntextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ntextBox.Location = new System.Drawing.Point(258, 25);
            this.ntextBox.Name = "ntextBox";
            this.ntextBox.ReadOnly = true;
            this.ntextBox.Size = new System.Drawing.Size(188, 20);
            this.ntextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ГОД СОЗДАНИЯ";
            // 
            // ytextBox
            // 
            this.ytextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ytextBox.Location = new System.Drawing.Point(258, 103);
            this.ytextBox.Name = "ytextBox";
            this.ytextBox.ReadOnly = true;
            this.ytextBox.Size = new System.Drawing.Size(188, 20);
            this.ytextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "АВТОР";
            // 
            // atextBox
            // 
            this.atextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.atextBox.Location = new System.Drawing.Point(258, 64);
            this.atextBox.Name = "atextBox";
            this.atextBox.ReadOnly = true;
            this.atextBox.Size = new System.Drawing.Size(188, 20);
            this.atextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ОБ ИСТОЧНИКЕ";
            // 
            // inftextBox
            // 
            this.inftextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inftextBox.Location = new System.Drawing.Point(177, 142);
            this.inftextBox.Multiline = true;
            this.inftextBox.Name = "inftextBox";
            this.inftextBox.ReadOnly = true;
            this.inftextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inftextBox.Size = new System.Drawing.Size(356, 216);
            this.inftextBox.TabIndex = 9;
            // 
            // delbutton
            // 
            this.delbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delbutton.Location = new System.Drawing.Point(468, 25);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(105, 23);
            this.delbutton.TabIndex = 10;
            this.delbutton.Text = "Удалить ";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // change
            // 
            this.change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change.Location = new System.Drawing.Point(468, 55);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(105, 23);
            this.change.TabIndex = 11;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // SourcesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 371);
            this.Controls.Add(this.change);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.inftextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.atextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ytextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ntextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Name = "SourcesInfo";
            this.Text = "SourcesInfo";
            this.Load += new System.EventHandler(this.SourcesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ntextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ytextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox atextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inftextBox;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.BindingSource sbindingSource;
        private System.Windows.Forms.Button change;
    }
}