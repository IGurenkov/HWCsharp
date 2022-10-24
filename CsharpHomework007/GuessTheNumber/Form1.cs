using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int number;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butPlayRestart_Click(object sender, EventArgs e)
        {            
            if (butStartGame.Text == "ИГРАТЬ")
            {
                number = random.Next(100);                
                butStartGame.Text = "ЗАНОВО";                
                labelCountTry.Enabled = true; 
                textBoxMyNumber.Enabled = true;
                labelMoreLess.Text = "";
            }
            else 
            {
                number = random.Next(100);
                count = 0;
                labelCountTry.Text = "КОЛИЧЕСТВО ПОПЫТОК: 0";
                textBoxMyNumber.Text = "";
                butTry.Enabled = false;
                labelMoreLess.Text = "";
            }
        }

        private void tBoxMyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!Char.IsDigit(e.KeyChar) && (!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {                
                butTry.Enabled = true;
            }
        }

        private void butTry_Click(object sender, EventArgs e)
        {
            butTry.Enabled = false;            
            int inputNumber = Convert.ToInt32(textBoxMyNumber.Text);            
            if (inputNumber > 100)
            {
                MessageBox.Show("Вы ввели значение больше, чем нужно. Повторите ввод.",
                    "УГАДАЙ ЧИСЛО", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMyNumber.Text = "";
            }
            else
            {
                labelCountTry.Text = "КОЛИЧЕСТВО ПОПЫТОК: " + (++count).ToString();
                if (inputNumber > number)
                {
                    labelMoreLess.Text = "Ваше число больше загаданного";
                }
                else if (inputNumber < number)
                {
                    labelMoreLess.Text = "Ваше число меньше загаданного";
                }
                else
                {
                    MessageBox.Show("Поздравляем!\n" + "Вы угадали число за " + count.ToString() +
                        " попыток.", "УГАДАЙ ЧИСЛО", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMyNumber.Text = "";
                    labelMoreLess.Text = "";
                    count = 0;
                    labelCountTry.Text = "КОЛИЧЕСТВО ПОПЫТОК: 0";
                    labelCountTry.Enabled = false;
                    textBoxMyNumber.Enabled = false;
                    butStartGame.Text = "ИГРАТЬ";
                }
            }
        }
    }
}
