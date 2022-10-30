using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample1
{
    public partial class Main : Form
    {
        public Sample Data { get; set; } = new Sample
        {
            MyProp = "Hello, GeekBrains!"
        };

        public Main()
        {
            InitializeComponent();
            labelData.Text = Data.MyProp;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogForm dialogForm = new DialogForm();
            dialogForm.Data = Data;
            dialogForm.UpdateData();
            if ( dialogForm.ShowDialog() == DialogResult.OK)
            {
                labelData.Text = Data.MyProp;
            }

        }
    }
}
