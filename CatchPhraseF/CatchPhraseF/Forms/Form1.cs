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
    public partial class Form1 : Form
    {
        AList alist = new AList();
        PList plist = new PList();
        SList slist = new SList();
        TList tlist = new TList();
        AddAuthor addAuthor = new AddAuthor();
        AutorsInfo authInf = new AutorsInfo();
        AddSource addSource = new AddSource();
        SourcesInfo sourceInf = new SourcesInfo();
        AddPhrase addPhrase = new AddPhrase();
        AddTheme addTheme = new AddTheme();        
        List<Label> labels = new List<Label>();
        List<string> temp = new List<string>();
        int n=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Ref() // Обновление информации.
        {
            alist.Read();
            slist.Read();
            plist.Read();                     
        }

        private void WriteRes() // Отображение крылатых фраз в главном окне.
        {
            Ref();
            temp.Clear();
            labels.Clear();
            respanel.Controls.Clear();

            if (n == 0) // Все фразы.
            {
                temp = plist.AllP();
            }
            else if (n == 1) // Результаты поиска по тексту.
            {
                temp = plist.Search(searchtextBox.Text, 0);
            }

            else if (n == 2) // Результат поиска по авторУ.
            {
                temp = plist.Search(searchtextBox.Text, 1);
            }

            else if (n == 3) // Результат поиска по источникам.
            {
                temp = plist.Search(searchtextBox.Text, 3);
            }

            else if (n == 4) // Результат поиска по теме.
            {
                temp = plist.Search(searchtextBox.Text, 2);

            }
            else if (n==5)  // Результат поиска по году.
            {
                temp = plist.Search(searchtextBox.Text, 4);

            }
                       

            int x = 0, y = 20;
            for (int i = 0; i < temp.Count; i++) // Вывод резултьтатов поиска на панель.
            {
                labels.Add(new Label());
                labels[labels.Count - 1].Text = temp[i];
                Size size = new Size(respanel.Width, Int32.MaxValue);
                TextFormatFlags flags = TextFormatFlags.WordBreak;
                size = TextRenderer.MeasureText(labels[labels.Count - 1].Text, labels[labels.Count - 1].Font, size, flags);
                labels[labels.Count - 1].MinimumSize = new Size(respanel.Size.Width - 20, size.Height + 20);
                if (labels.Count == 1)
                {
                    labels[labels.Count - 1].Location = new Point(x, y);
                }
                else
                {                    
                    y += labels[i - 1].Size.Height +20;
                    labels[labels.Count - 1].Location = new Point(x, y);                   
                }
                labels[labels.Count - 1].Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
                respanel.Controls.Add(labels[labels.Count - 1]);                
                labels[labels.Count - 1].ContextMenuStrip = contextMenuStrip;
            }

        }

        private void добавитьАвтораToolStripMenuItem_Click(object sender, EventArgs e) // Открыть окно добавления автора.
        {
            if (alist.Length != 0)
            {
                alist[0].AddChange = true;
                alist.Write();
            }
            addAuthor.ShowDialog();
            alist.Read();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e) // Открыть окно информации об авторах.
        {
            authInf.ShowDialog();
            Ref();            
            WriteRes();
        }

        private void добавитьИсточникToolStripMenuItem_Click(object sender, EventArgs e) // Открыть окно добавления источника.
        {
            if (slist.Length != 0)
            {
                slist[0].AddChange = true;
                slist.Write();
            }            
            addSource.ShowDialog();
            Ref();

        }

        private void источникиToolStripMenuItem_Click(object sender, EventArgs e) // Открыть окно информации об источниках.
        {
            sourceInf.ShowDialog();
            Ref();            
            WriteRes();
        }

        private void добавитьФразуToolStripMenuItem_Click(object sender, EventArgs e) // Открыть окно добавления фразы.
        {
            if (plist.Length != 0)
            {
                plist[0].AddChange = true;
                plist.Write();
            }
            
            addPhrase.ShowDialog();
            Ref();
            WriteRes();
        }

        private void добавитьТемыToolStripMenuItem_Click(object sender, EventArgs e) // Открыть окно добавления темы.
        {            
            addTheme.ShowDialog();          
        }

        private void Form1_Load(object sender, EventArgs e) // Загрузка формы.
        {
            Text = "CatchFrase";           
            List<string> crit = new List<string>() { "По автору", "По источнику", "По теме", "По тексту","По году написания"};
            critcomboBox.Items.AddRange(crit.ToArray());
            critcomboBox.SelectedIndex = 0;
            WriteRes();
            
        }        

        private void searchtextBox_TextChanged(object sender, EventArgs e) // Введение символов в поле поиска.
        {
            searchtextBox.Enabled = true;
            if (critcomboBox.Text == "По тексту")
                n = 1;
            if (critcomboBox.Text == "По автору")
                n = 2;
            if (critcomboBox.Text == "По источнику")
                n = 3;
            if (critcomboBox.Text == "По теме")
                n = 4;
            if (critcomboBox.Text == "По году написания")
                n = 5;

            WriteRes();
            if (searchtextBox.Text == "")
            {
                respanel.Controls.Clear();
                n = 0;
                WriteRes();
            }
        }
        private int getpNum(Label l) // Возвращает номер фразы на панели отображения.
        {
            for (int i = 0; i < plist.Length; i++)
            {
                if (plist[i].ToString() == l.Text)
                {
                    return i;
                }
            }
            return -1;
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) // Удаление фразы.
        {
            var currp = contextMenuStrip.SourceControl as Label;
            var r = MessageBox.Show("Удалить фразу?","Удаление", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                plist.RemoveAt(getpNum(currp));
                plist.Write();
                WriteRes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteRes();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e) // Вызов окна изменения информации о фразе.
        {
            var currp = contextMenuStrip.SourceControl as Label;
            for (int i = 0; i < plist.Length; i++)
            {
                if (plist[i].ToString() == currp.Text)
                {
                    plist[i].Change = true;
                    break;
                }
            }
            plist[0].AddChange = false;
            plist.Write();            
            addPhrase.ShowDialog();            
            plist.Read();
            WriteRes();
            for (int i = 0; i < plist.Length; i++)
            {
                plist[i].Change = false;
            }
            
            
        }
    }
}
