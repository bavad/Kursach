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
    public partial class AddTheme : Form
    {
        TList tlist = new TList();

        public AddTheme()
        {
            InitializeComponent();
        }

        private bool Check() // Проверка заполнено ли поле.
        {
            if (String.IsNullOrWhiteSpace(themetextBox.Text)) return false;            
            return true;
        }
        private void Clear() // Очистить поле.
        {
            themetextBox.Text = "";           
        }

        private void AddTheme_Load(object sender, EventArgs e) // Загрузка формы.
        {
            
            Text = "Добавление темы";
            
        }
        
        private void addtbutton_Click(object sender, EventArgs e) // Кнопка добавления тем
        {
            if (!Check())
            {
                MessageBox.Show("Поле не заполнено!");
                return;
            }
            
            
                tlist.Read();
                string[] str = themetextBox.Text.Split(';');
                for (int i = 0; i < str.Length; i++)
                if (!tlist.Exist(str[i]))
                    tlist.Add(tlist.RemoveSpaces(str[i]));
                tlist.Write();
                DialogResult = DialogResult.OK;

                Clear();
                Close();
            
        }

        private void canceltbutton_Click(object sender, EventArgs e) // Кноака отмены.
        {
            Clear();
            Close();
        }
    }
}
