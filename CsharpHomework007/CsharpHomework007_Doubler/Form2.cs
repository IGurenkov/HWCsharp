using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework006_Doubler
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        
        private void rulsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы победить Вам нужно с помощью кнопок +1 и х2 набрать число заданное компьютером", "Ruls", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doubler D = new Doubler();
            D.ShowDialog();
        }
    }
}
