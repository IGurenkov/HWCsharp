using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TrueFalseEditor
{
    public partial class Main : Form
    {
        TrueFalseEngine engine;        
        bool flag = false;
        int count = 0;
        int trueCount = 0;
        int QuestionCount = 1;

        public Main()
        {
            InitializeComponent();
            nudNumber.Hide();
            cbTrue.Hide();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                cbTrue.Show();
                nudNumber.Show();
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Add("", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                flag = true;                
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                nudNumber.Show();
                engine = new TrueFalseEngine(dlg.FileName);                
                engine.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = 1;
                flag = true;
                if (engine != null)
                {
                    cbTrue.Hide();
                }
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                cbTrue.Hide();
                engine.Save();
            }                       
            else
            {                
                MessageBox.Show("НЕТ БАЗЫ ДАННЫХ! ЗАГРУЗИТЕ ФАЙЛ!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                cbTrue.Show();
                engine.Add($"#{engine.Count + 1}", true);
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = engine.Count;
            }
            else
            {
                MessageBox.Show("НЕТ БАЗЫ ДАННЫХ! ЗАГРУЗИТЕ ФАЙЛ ИЛИ СОЗДАЙТЕ ЕГО!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                engine.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                nudNumber.Value--;
            }
            else
            {
                MessageBox.Show("НЕТ БАЗЫ ДАННЫХ! ЗАГРУЗИТЕ ФАЙЛ ИЛИ СОЗДАЙТЕ ЕГО!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                cbTrue.Hide();
                engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            else
            {
                MessageBox.Show("НЕТ БАЗЫ ДАННЫХ! ЗАГРУЗИТЕ ФАЙЛ ИЛИ СОЗДАЙТЕ ЕГО!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if(nudNumber.Value != 0)
            {
                tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
            }            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы: Гуренков И.А.\nВерсия программы: 1.0\nАвторские права: (с)Гуренков И.А.",
                    "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                engine.fileName = dlg.FileName;
                engine.Save();
            }
        }        

        private void buttTrue_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if(QuestionCount != engine.Count + 1)
                {
                    if (cbTrue.Checked == true)
                    {
                        try
                        {
                            QuestionCount++;
                            trueCount++;
                            labelCount.Text = "СЧЁТ: " + (++count).ToString();
                            tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                            cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
                            nudNumber.Value++;

                            MessageBox.Show("ВЕРНО!", "РЕЗУЛЬТАТ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show($"ВЫ ОТВЕТИЛИ НА ВСЕ ВОПРОСЫ!\nПРАВИЛЬНЫХ ОТВЕТОВ {trueCount} ИЗ {QuestionCount - 1}!\nНАЧНИТЕ НОВУЮ ИГРУ!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        try
                        {
                            QuestionCount++;
                            tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                            cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
                            nudNumber.Value++;
                            MessageBox.Show("НЕВЕРНО!", "РЕЗУЛЬТАТ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            MessageBox.Show("ВЫ ОТВЕТИЛИ НА ВСЕ ВОПРОСЫ!\nНАЧНИТЕ НОВУЮ ИГРУ!", "РЕЗУЛЬТАТ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ВЫ ОТВЕТИЛИ НА ВСЕ ВОПРОСЫ!\nНАЧНИТЕ НОВУЮ ИГРУ!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("НЕТ БАЗЫ ДАННЫХ! ЗАГРУЗИТЕ ФАЙЛ ИЛИ СОЗДАЙТЕ ЕГО!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttFalse_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (QuestionCount != engine.Count + 1)
                {
                    if (cbTrue.Checked == false)
                    {
                        try
                        {
                            QuestionCount++;
                            trueCount++;
                            labelCount.Text = "СЧЁТ: " + (++count).ToString();
                            tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                            cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
                            nudNumber.Value++;

                            MessageBox.Show("ВЕРНО!", "РЕЗУЛЬТАТ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show($"ВЫ ОТВЕТИЛИ НА ВСЕ ВОПРОСЫ!\nПРАВИЛЬНЫХ ОТВЕТОВ {trueCount} ИЗ {QuestionCount - 1}!\nНАЧНИТЕ НОВУЮ ИГРУ!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        try
                        {
                            QuestionCount++;
                            tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                            cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
                            nudNumber.Value++;

                            MessageBox.Show("НЕВЕРНО!", "РЕЗУЛЬТАТ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch
                        {
                            MessageBox.Show("ВЫ ОТВЕТИЛИ НА ВСЕ ВОПРОСЫ!\nНАЧНИТЕ НОВУЮ ИГРУ!", "РЕЗУЛЬТАТ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ВЫ ОТВЕТИЛИ НА ВСЕ ВОПРОСЫ!\nНАЧНИТЕ НОВУЮ ИГРУ!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("НЕТ БАЗЫ ДАННЫХ! ЗАГРУЗИТЕ ФАЙЛ ИЛИ СОЗДАЙТЕ ЕГО!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                nudNumber.Show();
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = 1;
                flag = true;
                count = 0;
                trueCount = 0;
                QuestionCount = 1;
                if (engine != null)
                {
                    cbTrue.Hide();
                }
            }
        }
    }
}
