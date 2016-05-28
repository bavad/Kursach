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
        PList plist = new PList();
        AddSource csourse = new AddSource();
        

        public SourcesInfo()
        {
            InitializeComponent();
        }

        private void SourcesInfo_Load(object sender, EventArgs e) //Загрузка формы.
        {
            slist.Read();
            Text = "Источники";
            if (slist.Length == 0)
            {
                MessageBox.Show("Список источников пуст");
                Close();
            }
            else
            {
                plist.Read();
                sbindingSource.DataSource = slist.Sources;
                listBox.SelectedIndex = 0;
                RefInf();             
                            

            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e) // Обновление полей формы при смене источника.
        {
            RefInf();
        }
        private void RefInf() // Метод обновления полей.
        {
            ntextBox.Text = slist[listBox.SelectedIndex].Name;
            ytextBox.Text = slist[listBox.SelectedIndex].Year;
            atextBox.Text = slist[listBox.SelectedIndex].Author.Name;
            inftextBox.Text = slist[listBox.SelectedIndex].Info;
        }

        private void delbutton_Click(object sender, EventArgs e) // Удаление источника.
        {
            for (int i = 0; i < plist.Length; i++)
            {
                if (plist[i].Source.Id == slist[listBox.SelectedIndex].Id)
                {
                    MessageBox.Show("Чтобы удалить данный источник, удалите все его афоризмы.",slist[listBox.SelectedIndex].Name);
                    return;
                }
            }
            var mes = MessageBox.Show("Вы действительно хотите удалить источник?", slist[listBox.SelectedIndex].Name, MessageBoxButtons.OKCancel);
            if (mes == DialogResult.OK)
            {
                slist.RemoveAt(listBox.SelectedIndex);
                slist.Write();
                slist.Read();
                sbindingSource.DataSource = slist.Sources;                
            }
            if (slist.Length == 0)
            {
                MessageBox.Show("Список авторов пока пуст.");
                Close();
            }
        }

        private void change_Click(object sender, EventArgs e) // Кнопка изменения информации об источнике.
        {
            slist[listBox.SelectedIndex].Change = true;
            slist[0].AddChange = false;
            slist.Write();
            csourse.ShowDialog();
            slist.Read();
            sbindingSource.DataSource = slist.Sources;
            RefInf();
            for (int i = 0; i < slist.Length; i++)
            {
                slist[i].Change = false;
            }
        }
    }
}
