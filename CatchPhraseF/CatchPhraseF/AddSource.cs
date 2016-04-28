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
    public partial class AddSource : Form
    {
        SList slist = new SList();
        AList alist = new AList();
        private double id;
        Source temp;

        public AddSource()
        {
            InitializeComponent();
        }
        private bool Check()
        {
            if (String.IsNullOrWhiteSpace(ntextBox.Text)) return false;
            if (acomboBox.SelectedIndex == -1) return false;
            if (String.IsNullOrWhiteSpace(ytextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(inftextBox.Text)) return false;
            return true;
        }
        private void Clear()
        {
            ntextBox.Text = "";
            ytextBox.Text = "";
            acomboBox.SelectedIndex = -1;
            inftextBox.Text = "";
        }
        private void AddSource_Load(object sender, EventArgs e)
        {
            alist.Read();
            slist.Read();
            abindingSource.DataSource = alist.Authors;
            acomboBox.SelectedIndex = -1;
            Text = "Добавление источника";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            string min = "", max = "";
            min = alist[acomboBox.SelectedIndex].Born.Split('.')[2];
            max = alist[acomboBox.SelectedIndex].Die.Split('.')[2];
            if (Convert.ToInt32(ytextBox.Text) < Convert.ToInt32(min) || Convert.ToInt32(ytextBox.Text) > Convert.ToInt32(max))
            {
                MessageBox.Show("Год не входит в рамки жизни автора");
                return;
            }
            double id = 0;
            slist.Read();
            if (slist.Length == 0)
                temp = new Source(slist.RemoveSpaces(ntextBox.Text),alist[acomboBox.SelectedIndex], ytextBox.Text,slist.RemoveSpaces(inftextBox.Text), id);
            else
            {
                id = slist[slist.Length - 1].Id + 1;
                temp = new Source(slist.RemoveSpaces(ntextBox.Text), alist[acomboBox.SelectedIndex], ytextBox.Text, slist.RemoveSpaces(inftextBox.Text), id);
            }
            slist.Add(temp);
            DialogResult = DialogResult.OK;
            slist.Write();
            Clear();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
