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
        Author temp;
        public AddAuthor()
        {
            InitializeComponent();
        }
        private bool Check()
        {
            if (String.IsNullOrWhiteSpace(ntextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(btextBox.Text)) return false;
            if (String.IsNullOrWhiteSpace(biotextBox.Text)) return false;
            return true;
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {
            alist.Read();
            Text = "Добавить автора";
        }
        private void Clear()
        {
            ntextBox.Text = "";
            btextBox.Text = "";
            dtextBox.Text = "";
            dtextBox.Mask = "00/00/0000";
            btextBox.Mask = "00/00/0000";
            biotextBox.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
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
                
                try
                {
                    id = 0;
                    if (alist.Length == 0)
                    {
                        temp = new Author(alist.RemoveSpaces(ntextBox.Text),btextBox.Text, dtextBox.Text,alist.RemoveSpaces(biotextBox.Text),id);
                    }
                    else
                    {
                        id =alist[alist.Length - 1].Id + 1;
                        temp = new Author(alist.RemoveSpaces(ntextBox.Text),btextBox.Text, dtextBox.Text, alist.RemoveSpaces(biotextBox.Text), id);
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

                Clear();
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
            Close();
            
        }
    }
        
       
        }
    
    
        

