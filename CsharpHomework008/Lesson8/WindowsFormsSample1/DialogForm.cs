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
    public partial class DialogForm : Form
    {

        public Sample Data { get; set; }

        public DialogForm()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            textBoxData.Text = Data.MyProp;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Data.MyProp = textBoxData.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
