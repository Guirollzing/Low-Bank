using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowBank.Windows.Presentation
{
    public partial class AmmountTransfer : Form
    {
        const char BACKSPACE_CHAR = '\b';
        public AmmountTransfer()
        {
            InitializeComponent();
        
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
                   
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBoxBase campoDeTexto)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }
        }
    }
}
