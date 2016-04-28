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
        AddAuthor addAuthor = new AddAuthor();
        AutorsInfo authInf = new AutorsInfo();
        AddSource addSource = new AddSource();
        SourcesInfo sourceInf = new SourcesInfo();
        AddPhrase addPhrase = new AddPhrase();

        public Form1()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            alist.Read();
            slist.Read();            
        }

        private void добавитьАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alist.Length != 0)
            {
                alist.Write();
            }
            addAuthor.ShowDialog();
            alist.Read();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authInf.ShowDialog();
            Refresh();
            if (authInf.DialogResult == DialogResult.OK)
            {
               Refresh();               
            }
        }

        private void добавитьИсточникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slist.Write();
            addSource.ShowDialog();

        }

        private void источникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourceInf.ShowDialog();
            Refresh();
            if (sourceInf.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void добавитьФразуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plist.Write();
            addPhrase.ShowDialog();
            Refresh();
        }
    }
}
