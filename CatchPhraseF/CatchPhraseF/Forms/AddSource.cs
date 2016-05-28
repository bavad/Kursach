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
        private bool add;
        Source temp;

        public AddSource()
        {
            InitializeComponent();
        }

        private bool Check() // Проверка - заполнены ли все поля.
        {
            if (String.IsNullOrWhiteSpace(ntextBox.Text)) return false;
            if (acomboBox.SelectedIndex == -1) return false;
            if (String.IsNullOrWhiteSpace(ytextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(inftextBox.Text)) return false;
            return true;
        }

        private void Clear() // Очистить все поля.
        {
            ntextBox.Text = "";
            ytextBox.Text = "";
            acomboBox.SelectedIndex = -1;
            inftextBox.Text = "";
        }
        private void AddSource_Load(object sender, EventArgs e) // Загрузка формы.
        {
            alist.Read();
            slist.Read();
            abindingSource.DataSource = alist.Authors;
            acomboBox.SelectedIndex = -1;
            if (slist.Length == 0 || slist[0].AddChange) // В случае добавления источника.
            {
                add = true;
                AddButton.Text = "Добавить";
                Text = "Добавить источник";
            }
            else // В случае изменения информации об авторе. 
            {
                add = false;
                AddButton.Text = "Изменить";
                Text = "Изменить информацию об источнике";
                for (int i = 0; i < alist.Length; i++)
                {
                    if (slist[i].Change)
                    {
                        ntextBox.Text = slist[i].Name;
                        ytextBox.Text = slist[i].Year;
                        acomboBox.Text = slist[i].Author.Name;
                        inftextBox.Text = slist[i].Info;
                        break;
                    }
                }

            }
            alist[0].AddChange = false;
            
        }

        private void AddButton_Click(object sender, EventArgs e) // Кнопка добавления источника(изменения информации об источнике).
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
            
            if (add == true) // В случае добавления источника.
            {
                id = 0;
                slist.Read();
                if (slist.Length == 0)
                    temp = new Source(slist.RemoveSpaces(ntextBox.Text), alist[acomboBox.SelectedIndex], ytextBox.Text, slist.RemoveSpaces(inftextBox.Text), id);
                else
                {
                    id = slist[slist.Length - 1].Id + 1;
                    temp = new Source(slist.RemoveSpaces(ntextBox.Text), alist[acomboBox.SelectedIndex], ytextBox.Text, slist.RemoveSpaces(inftextBox.Text), id);
                }
                if (slist.Exist(temp))
                {
                    MessageBox.Show("Этот источник уже существует");
                    return;
                }
                slist.Add(temp);
                DialogResult = DialogResult.OK;
                slist.Write();
            }
            else // В случае изменения информации об источнике.
            {
                PList plist = new PList();
                plist.Read();
                slist.Read();
                for (int i = 0; i < slist.Length; i++)
                {
                    if (slist[i].Change)
                    {
                        slist[i].Name = slist.RemoveSpaces(ntextBox.Text);
                        slist[i].Year = ytextBox.Text;
                        slist[i].Author = alist[acomboBox.SelectedIndex];
                        slist[i].Info = slist.RemoveSpaces(inftextBox.Text);
                        alist[i].Change = false;
                        for (int j = 0; j < plist.Length; j++)
                        {
                            if (plist[j].Source.Id == slist[i].Id)
                            {
                                plist[j].Source = slist[i];
                                plist[j].Author = slist[i].Author;
                                plist[j].Year = slist[i].Year;
                            }
                        }
                        break;
                    }
                }
                slist.Write();
                plist.Write();
            }
            Clear();
            Close();
        }

        private void button2_Click(object sender, EventArgs e) // Кнопка отмены.
        {
            Clear();
            Close();
        }
    }
}
