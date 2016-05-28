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
    public partial class AddAuthor : Form
    {
        AList alist = new AList();
        private double id;
        private bool add;
        Author temp;

        public AddAuthor()
        {
            InitializeComponent();
        }

        private bool Check() // Проверка - заполнены ли все поля. 
        {
            if (String.IsNullOrWhiteSpace(ntextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(btextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(dtextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(biotextBox.Text)) return false;
            return true;
        }

        private void AddAuthor_Load(object sender, EventArgs e) // Загрузка формы.
        {
            alist.Read();
            if (alist.Length == 0 || alist[0].AddChange) // В случае добавления автора.
            {
                add = true;
                AddButton.Text = "Добавить";
                Text = "Добавить автора";
            }
            else // В случае изменения информации.
            {
                add = false;
                AddButton.Text = "Изменить";
                Text = "Изменить информацию об авторе";
                for (int i = 0; i < alist.Length; i++)
                {
                    if (alist[i].Change)
                    {
                        ntextBox.Text = alist[i].Name;
                        btextBox.Text = alist[i].Born;
                        dtextBox.Text = alist[i].Die;
                        biotextBox.Text = alist[i].Bio;                        
                        break;
                    }
                }
                
            }
            alist[0].AddChange = false;

        }
        private void Clear() // Очистить все поля.
        {
            ntextBox.Text = "";
            btextBox.Text = "";
            dtextBox.Text = "";
            dtextBox.Mask = "00/00/0000";
            btextBox.Mask = "00/00/0000";
            biotextBox.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e) // Кнопка добавления автора(изменения информации об авторе).
        { 
          if (Check())
            {
                string BornYear = "";
                string DeadYear = "";
                
                try {
                    if (!alist.checkDate(btextBox.Text))
                    {
                        MessageBox.Show("Неверная дата");
                        return;
                    }
                    if (!alist.checkDate(dtextBox.Text))
                    {
                        MessageBox.Show("Неверная дата");
                        return;
                    }

                }
                catch
                {
                    MessageBox.Show("Неверная дата");
                    return;
                } 

                    BornYear = btextBox.Text.Split('.')[2]; 
                    DeadYear = dtextBox.Text.Split('.')[2]; 
                    
                if (Convert.ToInt32(DeadYear) < Convert.ToInt32(BornYear))
                {
                    MessageBox.Show("Неверная дата");
                    return;
                }
                if (add == true) // В случае добавления автора.
                {
                    try
                    {
                        id = 0;
                        if (alist.Length == 0)
                        {
                            temp = new Author(alist.RemoveSpaces(ntextBox.Text), btextBox.Text, dtextBox.Text, alist.RemoveSpaces(biotextBox.Text), id);
                        }
                        else
                        {
                            id = alist[alist.Length - 1].Id + 1;
                            temp = new Author(alist.RemoveSpaces(ntextBox.Text), btextBox.Text, dtextBox.Text, alist.RemoveSpaces(biotextBox.Text), id);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неверно заполнены поля");
                        return;
                    }
                    if (alist.Exist(temp))
                    {
                        MessageBox.Show("Этот автор уже существует");
                        return;
                    }
                    alist.Add(temp);
                    DialogResult = DialogResult.OK;
                    alist.Write();
                }
                else // В случае изменения информации об авторе.
                {
                    PList plist = new PList();
                    plist.Read();
                    alist.Read();
                    for (int i = 0; i < alist.Length; i++)
                    {
                        if (alist[i].Change)
                        {
                            alist[i].Name = alist.RemoveSpaces(ntextBox.Text);
                            alist[i].Born = btextBox.Text;
                            alist[i].Die = dtextBox.Text;
                            alist[i].Bio = alist.RemoveSpaces(biotextBox.Text);                            
                            alist[i].Change = false;
                            for (int j = 0; j < plist.Length; j++)
                            {
                                if (plist[j].Author.Id == alist[i].Id)
                                {
                                    plist[j].Author = alist[i];
                                }
                            }
                            break;
                        }
                    }
                    alist.Write();
                    plist.Write();
                }
                Clear();
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) // Кнопка отмены.
        {
            Clear();
            Close();
            
        }
    }
        
}
    
    
        

