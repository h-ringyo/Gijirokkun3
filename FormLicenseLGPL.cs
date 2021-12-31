using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gijirokkun3
{
    public partial class FormLicenseLGPL : Form
    {
        public FormLicenseLGPL()
        {
            InitializeComponent();
        }

        private void FormLicenseLGPL_Load(object sender, EventArgs e)
        {
            // textbox内の全選択状態を解除する
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
        }
    }
}
