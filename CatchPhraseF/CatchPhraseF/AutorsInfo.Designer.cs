namespace CatchPhraseF
{
    partial class AutorsInfo
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.abindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.biotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearsBox = new System.Windows.Forms.TextBox();
            this.delbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.DataSource = this.abindingSource;
            this.listBox.DisplayMember = "Name";
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 25);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 329);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // abindingSource
            // 
            this.abindingSource.AllowNew = false;
            this.abindingSource.DataSource = typeof(CatchPhraseF.Model.Author);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "БИОГРАФИЯ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "АВТОРЫ";
            // 
            // biotextBox
            // 
            this.biotextBox.Location = new System.Drawing.Point(152, 130);
            this.biotextBox.Multiline = true;
            this.biotextBox.Name = "biotextBox";
            this.biotextBox.ReadOnly = true;
            this.biotextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.biotextBox.Size = new System.Drawing.Size(410, 224);
            this.biotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "АВТОР";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(287, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(128, 20);
            this.nameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ГОДЫ ЖИЗНИ";
            // 
            // yearsBox
            // 
            this.yearsBox.Location = new System.Drawing.Point(287, 73);
            this.yearsBox.Name = "yearsBox";
            this.yearsBox.ReadOnly = true;
            this.yearsBox.Size = new System.Drawing.Size(128, 20);
            this.yearsBox.TabIndex = 7;
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(448, 22);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(114, 23);
            this.delbutton.TabIndex = 8;
            this.delbutton.Text = "Удалить автора";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // AutorsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 369);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.yearsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.biotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "AutorsInfo";
            this.Text = "AutorsInfo";
            this.Load += new System.EventHandler(this.AutorsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox biotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearsBox;
        private System.Windows.Forms.BindingSource abindingSource;
        private System.Windows.Forms.Button delbutton;
    }
}