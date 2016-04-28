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
    public partial class SourcesInfo : Form
    {
        SList slist = new SList();
        AddSource csourse = new AddSource();
        int ssource;
        public SourcesInfo()
        {
            InitializeComponent();
        }

        private void SourcesInfo_Load(object sender, EventArgs e)
        {
            slist.Read();
            if (slist.Length == 0)
            {
                MessageBox.Show("Список источников пуст");
                Close();
            }
            else
            {
                listBox.Enabled = true;
                delbutton.Visible = true;
                ssource = -1;
                sbindingSource.DataSource = slist.Sources;
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
            ntextBox.Text = slist[listBox.SelectedIndex].Name;
            ytextBox.Text = slist[listBox.SelectedIndex].Year;
            atextBox.Text = slist[listBox.SelectedIndex].Author.Name;
            inftextBox.Text = slist[listBox.SelectedIndex].Info;
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            var mes = MessageBox.Show("Вы действительно хотите удалить источник?", slist[listBox.SelectedIndex].Name, MessageBoxButtons.OKCancel);
            if (mes == DialogResult.OK)
            {
                slist.RemoveAt(listBox.SelectedIndex);
                slist.Write();
                slist.Read();
                sbindingSource.DataSource = slist.Sources;
                ntextBox.Text = "";
                ytextBox.Text = "";
                inftextBox.Text = "";
                atextBox.Text = "";
            }
            if (slist.Length == 0)
            {
                MessageBox.Show("Список авторов пока пуст.");
                Close();
            }
        }
    }
}
