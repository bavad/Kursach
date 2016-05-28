namespace CatchPhraseF
{
    partial class AddTheme
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
            this.label1 = new System.Windows.Forms.Label();
            this.themetextBox = new System.Windows.Forms.TextBox();
            this.addtbutton = new System.Windows.Forms.Button();
            this.canceltbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите темы через точку с запятой, которые хотите добавить:";
            // 
            // themetextBox
            // 
            this.themetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themetextBox.Location = new System.Drawing.Point(12, 25);
            this.themetextBox.Name = "themetextBox";
            this.themetextBox.Size = new System.Drawing.Size(390, 20);
            this.themetextBox.TabIndex = 1;
            // 
            // addtbutton
            // 
            this.addtbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addtbutton.Location = new System.Drawing.Point(12, 51);
            this.addtbutton.Name = "addtbutton";
            this.addtbutton.Size = new System.Drawing.Size(92, 23);
            this.addtbutton.TabIndex = 2;
            this.addtbutton.Text = "Добавить";
            this.addtbutton.UseVisualStyleBackColor = true;
            this.addtbutton.Click += new System.EventHandler(this.addtbutton_Click);
            // 
            // canceltbutton
            // 
            this.canceltbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.canceltbutton.Location = new System.Drawing.Point(122, 51);
            this.canceltbutton.Name = "canceltbutton";
            this.canceltbutton.Size = new System.Drawing.Size(87, 23);
            this.canceltbutton.TabIndex = 3;
            this.canceltbutton.Text = "Отмена";
            this.canceltbutton.UseVisualStyleBackColor = true;
            this.canceltbutton.Click += new System.EventHandler(this.canceltbutton_Click);
            // 
            // AddTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 84);
            this.Controls.Add(this.canceltbutton);
            this.Controls.Add(this.addtbutton);
            this.Controls.Add(this.themetextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddTheme";
            this.Text = "AddTheme";
            this.Load += new System.EventHandler(this.AddTheme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox themetextBox;
        private System.Windows.Forms.Button addtbutton;
        private System.Windows.Forms.Button canceltbutton;
    }
}