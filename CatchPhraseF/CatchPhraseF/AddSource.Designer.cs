namespace CatchPhraseF
{
    partial class AddSource
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
            this.ntextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ytextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acomboBox = new System.Windows.Forms.ComboBox();
            this.abindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.inftextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // ntextBox
            // 
            this.ntextBox.Location = new System.Drawing.Point(121, 28);
            this.ntextBox.Name = "ntextBox";
            this.ntextBox.Size = new System.Drawing.Size(284, 20);
            this.ntextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год создания:";
            // 
            // ytextBox
            // 
            this.ytextBox.Location = new System.Drawing.Point(121, 60);
            this.ytextBox.Mask = "0000";
            this.ytextBox.Name = "ytextBox";
            this.ytextBox.Size = new System.Drawing.Size(284, 20);
            this.ytextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор:";
            // 
            // acomboBox
            // 
            this.acomboBox.DataSource = this.abindingSource;
            this.acomboBox.DisplayMember = "Name";
            this.acomboBox.FormattingEnabled = true;
            this.acomboBox.Location = new System.Drawing.Point(121, 91);
            this.acomboBox.Name = "acomboBox";
            this.acomboBox.Size = new System.Drawing.Size(284, 21);
            this.acomboBox.TabIndex = 5;
            // 
            // abindingSource
            // 
            this.abindingSource.DataSource = typeof(CatchPhraseF.Model.Author);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Об источнике:";
            // 
            // inftextBox
            // 
            this.inftextBox.Location = new System.Drawing.Point(124, 131);
            this.inftextBox.Multiline = true;
            this.inftextBox.Name = "inftextBox";
            this.inftextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inftextBox.Size = new System.Drawing.Size(281, 147);
            this.inftextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(222, 294);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(82, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 333);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.inftextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.acomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ytextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ntextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddSource";
            this.Text = "AddSource";
            this.Load += new System.EventHandler(this.AddSource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ntextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ytextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox acomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inftextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource abindingSource;
    }
}