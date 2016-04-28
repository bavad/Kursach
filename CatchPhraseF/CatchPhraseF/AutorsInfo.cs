using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchPhraseF.Model;

namespace CatchPhraseF
{
    [Serializable]
    public partial class AutorsInfo : Form
    {
        AList alist = new AList();
        AddAuthor cauthor = new AddAuthor();
        

        public AutorsInfo()
        {
            InitializeComponent();
        }

        private void AutorsInfo_Load(object sender, EventArgs e)
        {
            alist.Read();
            if (alist.Length == 0)
            {
                MessageBox.Show("Список авторов пуст");
                Close();
            }
            else
            {
                listBox.Enabled = true;
                delbutton.Visible = true;
                abindingSource.DataSource = alist.Authors;                 
                listBox.SelectedIndex = 0;
                RefInf();
                                              
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefInf();
        }
        private void RefInf()
        {
            nameBox.Text = alist[listBox.SelectedIndex].Name;
            yearsBox.Text = alist[listBox.SelectedIndex].Born + " - " + alist[listBox.SelectedIndex].Die;
            biotextBox.Text = alist[listBox.SelectedIndex].Bio;
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            var mes = MessageBox.Show("Вы действительно хотите удалить автора?",alist[listBox.SelectedIndex].Name, MessageBoxButtons.OKCancel);
            if (mes == DialogResult.OK)
            {
                alist.RemoveAt(listBox.SelectedIndex);
                alist.Write();
                alist.Read();
                abindingSource.DataSource = alist.Authors;
                nameBox.Text = "";
                yearsBox.Text = "";
                biotextBox.Text = "";                
            }
            if (alist.Length == 0)
            {
                MessageBox.Show("Список авторов пока пуст.");
                Close();
            }
        }
    }
}
