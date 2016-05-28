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
        SList slist = new SList();
        AddAuthor cauthor = new AddAuthor();      
        

        public AutorsInfo()
        {
            InitializeComponent();
        }

        private void AutorsInfo_Load(object sender, EventArgs e) // Загрузка формы.
        {
            alist.Read();
            Text = "Авторы";
            if (alist.Length == 0)
            {
                MessageBox.Show("Список авторов пуст");
                Close();
            }
            else
            {
                slist.Read();
                abindingSource.DataSource = alist.Authors;
                alist.Write();
                listBox.SelectedIndex = 0;
                RefInf();
                                              
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e) // Обновление полей формы при смене автора.
        {
            RefInf();
        }
        private void RefInf() // Метод обновления полей.
        {
            nameBox.Text = alist[listBox.SelectedIndex].Name;
            yearsBox.Text = alist[listBox.SelectedIndex].Born + " - " + alist[listBox.SelectedIndex].Die;
            biotextBox.Text = alist[listBox.SelectedIndex].Bio;
        }

        private void delbutton_Click(object sender, EventArgs e) // Удаление автора.
        {

            for (int i = 0; i < slist.Length; i++)
            {
                if (slist[i].Author.Id == alist[listBox.SelectedIndex].Id)
                {
                    MessageBox.Show("Чтобы удалить данного автора, удалите все его источники.",alist[listBox.SelectedIndex].Name);
                    return;
                }
            }
            var mes = MessageBox.Show("Вы действительно хотите удалить автора?",alist[listBox.SelectedIndex].Name, MessageBoxButtons.OKCancel);
            if (mes == DialogResult.OK)
            {
                alist.RemoveAt(listBox.SelectedIndex);
                alist.Write();
                alist.Read();
                abindingSource.DataSource = alist.Authors;
                               
            }
            if (alist.Length == 0)
            {
                MessageBox.Show("Список авторов пока пуст.");
                Close();
            }
        }

        private void change_Click(object sender, EventArgs e) //Кнопка изменеия информации об авторе.
        {
            alist[listBox.SelectedIndex].Change = true;
            alist[0].AddChange = false;
            alist.Write();
            cauthor.ShowDialog();
            alist.Read();
            abindingSource.DataSource = alist.Authors;
            RefInf();
            for (int i = 0; i < alist.Length; i++)
            {
                alist[i].Change = false;
            }
        }
    }
}
