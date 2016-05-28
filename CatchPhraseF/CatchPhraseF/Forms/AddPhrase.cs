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
        TList tlist = new TList();
        private double id;
        private bool add;
        Phrase temp;

        public AddPhrase()
        {
            InitializeComponent();
        }

        private void AddPhrase_Load(object sender, EventArgs e) // Загрузка формы.
        {
            alist.Read();
            slist.Read();
            plist.Read();
            
            abindingSource.DataSource = alist.Authors;
            acomboBox.SelectedIndex = -1;

            tlist.Read();
            
            tcomboBox.Items.Clear();
            tcomboBox.Items.AddRange(tlist.Themes.ToArray());
            tcomboBox.SelectedIndex = -1;
            Clear();

            if (plist.Length == 0 || plist[0].AddChange) // В случае добавления фразы.
            {
                
                add = true;
                button1.Text = "Добавить";
                Text = "Добавить Фразу";
                
            }
            else // В случае изменения информации о фразе.
            {
                add = false;
                button1.Text = "Изменить";
                Text = "Изменить фразу";
                for (int i = 0; i < plist.Length; i++)
                {
                    if (plist[i].Change)
                    {
                        acomboBox.Text = plist[i].Author.Name;
                        scomboBox.Text = plist[i].Source.Name;
                        tcomboBox.Text = plist[i].Theme;
                        phrasetextBox.Text = plist[i].Content;                        
                        break;
                    }
                }
            }
            plist[0].AddChange = false;
        }

        List<Source> source;
        private void acomboBox_SelectedIndexChanged(object sender, EventArgs e) // Выбирает источники соответствующе выбранному автору.
        {
            if (acomboBox.SelectedIndex != -1)
            {
                source = slist.AuthSources(alist[acomboBox.SelectedIndex]);
                sbindingSource.DataSource = source;
                scomboBox.SelectedIndex = -1;
            }
        }
        
        private int sourceIndex() // Получение номера в колекции источника из списка источников, соотоветствующих выбранному автору.
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

        private bool Check() // Проверка - заполнены ли все поля.
        {
            if (acomboBox.SelectedIndex == -1) return false;
            if (scomboBox.SelectedIndex == -1) return false;
            if(tcomboBox.SelectedIndex == -1) return false;
            if (String.IsNullOrWhiteSpace(phrasetextBox.Text)) return false;
            return true;
        }
        private void Clear() // Очистить все поля.
        {
            acomboBox.SelectedIndex = -1;
            scomboBox.SelectedIndex = -1;
            tcomboBox.SelectedIndex = -1;
            phrasetextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) // Кнопка добавления фразы(изменения информации о фразе).
        {
            if (!Check())
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (add == true) // В случае добавления фразы.
            {               
                
                id = 0;
                if (plist.Length == 0)
                    temp = new Phrase(plist.RemoveSpaces(phrasetextBox.Text), slist[sourceIndex()].Year, alist[acomboBox.SelectedIndex], slist[sourceIndex()], tcomboBox.Text, id);
                else
                {
                    id = plist[plist.Length - 1].Id + 1;
                    temp = new Phrase(plist.RemoveSpaces(phrasetextBox.Text), slist[sourceIndex()].Year, alist[acomboBox.SelectedIndex], slist[sourceIndex()], tcomboBox.Text, id);
                }
                if (plist.Exist(temp))
                {
                    MessageBox.Show("Эта фраза уже существует");
                    return;
                }
                plist.Add(temp);
                DialogResult = DialogResult.OK; 
                plist.Write();  
                
            }
            else // В случае изменения информации о фразе.
            {
                plist.Read();
                for (int i = 0; i < plist.Length; i++)
                {
                    if (plist[i].Change)
                    {
                        plist[i].Author = alist[acomboBox.SelectedIndex];
                        plist[i].Source = slist[sourceIndex()];
                        plist[i].Theme = tcomboBox.Text;
                        plist[i].Content = plist.RemoveSpaces(phrasetextBox.Text);                        
                        break;
                    }
                }
                plist.Write();
                
            }
           
            Clear();
            Close();
        }
        

        private void button2_Click(object sender, EventArgs e) //Кнопка отмены.
        {
            Clear();
            Close();
        }
    }
}
