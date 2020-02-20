using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingSystem
{
    public partial class MainForm : Form
    {
        // Конструктор формы
        //
        public MainForm()
        {
            InitializeComponent();
        }

        //Обработчик события нажатия на кнопку buttonOpenQuestions
        //
        private void buttonOpenQuestions_Click(object sender, EventArgs e)
        {
            //пробегаемся по дочерним окнам основного окна
            foreach (Form chform in this.MdiChildren) 
            {
                if (chform.Name == "ListTests") 
                {
                    this.ActivateMdiChild((ListTests)chform);
                    return;
                }
            }

            // Если такое окно не нашли, откроем новое
            ListTests cf = new ListTests();
            cf.MdiParent = this;
            cf.Show();
        }

        // Обработчик события нажатия на кнопку comandКаскад в меню menuStrip1
        //
        private void comandКаскад_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        //Обработчик события нажатия на кнопку settingsToolStripMenuItem меню menuStrip1
        //
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //пробегаемся по дочерним окнам основного окна
            foreach (Form chform in this.MdiChildren)
            {
                if (chform.Name == "Settings")
                {
                    this.ActivateMdiChild((Settings)chform);
                    return;
                }
            }

            // Если такое окно не нашли, откроем новое
            Settings cf = new Settings();
            cf.MdiParent = this;
            cf.Show();
        }




    }
}
