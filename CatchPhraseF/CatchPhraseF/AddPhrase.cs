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
    public partial class AddPhrase : Form
    {
        AList alist = new AList();
        SList slist = new SList();
        PList plist = new PList();
        private double id;
        Phrase temp;

        public AddPhrase()
        {
            InitializeComponent();
        }

        private void AddPhrase_Load(object sender, EventArgs e)
        {
            Text = "Добавить фразу";
            alist.Read();
            slist.Read();
            plist.Read();
            abindingSource.DataSource = alist.Authors;
            acomboBox.SelectedIndex = -1;
        }

        List<Source> source;
        private void acomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (acomboBox.SelectedIndex != -1)
            {
                source = slist.AuthSources(alist[acomboBox.SelectedIndex]);
                sbindingSource.DataSource = source;
                scomboBox.SelectedIndex = -1;
            }
        }
        private int getnums()
        {
            int r = -1;
            for (int i = 0; i < slist.Length; i++)
            {
                if (slist[i].Id == source[scomboBox.SelectedIndex].Id)
                {
                    r = i;
                    break;
                }
            }
            return r;
        }
        private bool Check()
        {
            if (acomboBox.SelectedIndex == -1) return false;
            if (scomboBox.SelectedIndex == -1) return false;
            if (String.IsNullOrWhiteSpace(phrasetextBox.Text)) return false;
            return true;
        }
        private void Clear()
        {
            acomboBox.SelectedIndex = -1;
            scomboBox.SelectedIndex = -1;            
            phrasetextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            id = 0;
            plist.Read();
            if (plist.Length == 0)
                temp = new Phrase(plist.RemoveSpaces(phrasetextBox.Text), slist[this.getnums()].Year, alist[acomboBox.SelectedIndex], slist[this.getnums()], id);
            else
            {
                id = plist[plist.Length - 1].Id + 1;
                temp = new Phrase(plist.RemoveSpaces(phrasetextBox.Text), slist[this.getnums()].Year, alist[acomboBox.SelectedIndex], slist[this.getnums()], id);
            }

            plist.Add(temp);
            DialogResult = DialogResult.OK;
            plist.Write();
            Clear();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
