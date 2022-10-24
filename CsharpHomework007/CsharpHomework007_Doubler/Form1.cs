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
    public partial class Doubler : Form
    {
        private Random random = new Random();        
        private Stack<int> cancel1 = new Stack<int>();
        private int ComputerNumber;
        private int UserNumber;
        private int sum;

        
        public Doubler()
        {            
            InitializeComponent();            
            UpdateStateGame(UserNumber, random.Next(20));            
        }

        public void UpdateStateGame(int UserNumber)
        {            
            LabelUserNumber.Text = $"ТЕКУЩЕЕ ЧИСЛО: {UserNumber}";
            cancel1.Push(UserNumber);
        }

        private void UpdateStateGame(int UserNumber, int ComputerNumber)
        {            
            UpdateStateGame(UserNumber);
            this.ComputerNumber = ComputerNumber;
            LabelComputerNumber.Text = $"ПОЛУЧИТЕ ЧИСЛО: {ComputerNumber}";            
        }

        private void NewGame_Click(object sender, EventArgs e)
        {            
            UpdateStateGame(UserNumber *= 0, random.Next(20));
            CommandSumm1.Text = $"ЧИСЛО ПОПЫТОК: {sum = 0}";
        }

        private void Plus_Click(object sender, EventArgs e)
        {            
            UpdateStateGame(++UserNumber);
            sum = sum + 1;            
            CommandSumm1.Text = $"ЧИСЛО ПОПЫТОК: {sum}";
            CheckWin();            
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            UpdateStateGame(UserNumber *= 2);
            sum = sum + 1;            
            CommandSumm1.Text = $"ЧИСЛО ПОПЫТОК: {sum}";
            CheckWin();            
        }

        private void CheckWin ()
        {
            if(UserNumber == ComputerNumber)
            {
                if(MessageBox.Show("Вы успешно завершили игру!\nНачать новую игру?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    UpdateStateGame(UserNumber *= 0, random.Next(20));
                    CommandSumm1.Text = $"ЧИСЛО ПОПЫТОК: {sum = 0}";
                }
                else
                {
                    Close();
                }
            }
            else if(UserNumber > ComputerNumber)
            {
                if (MessageBox.Show("Вы проиграли!\n" + "Загаданное число: " + ComputerNumber + "\nВаше число: " + UserNumber + "\nНачать новую игру?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    UpdateStateGame(UserNumber *= 0, random.Next(20));
                    CommandSumm1.Text = $"ЧИСЛО ПОПЫТОК: {sum = 0}";
                }
                else
                {
                    Close();
                }
            }

        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;            
            UpdateStateGame(UserNumber *= 0, i = random.Next(20));
            MessageBox.Show("Вы должны получить число: " + i, "Задание", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            CommandSumm1.Text = $"ЧИСЛО ПОПЫТОК: {sum = 0}";
        }

        private void rulsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы победить Вам нужно с помощью кнопок +1 и х2 набрать число заданное компьютером", "Ruls", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void Doubler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void Cancel_Click(object sender, EventArgs e)
        {
            cancel1.Pop();
            UserNumber = cancel1.Peek();
            LabelUserNumber.Text = $"ТЕКУЩЕЕ ЧИСЛО: {UserNumber}";            
        }
    }
}
