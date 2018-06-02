using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonOS
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            mtbTel.Focus();
            mtbTel.Select(1, 0);
        }

       
    }
}
