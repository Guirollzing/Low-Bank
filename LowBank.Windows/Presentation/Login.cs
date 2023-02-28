using LowBank.Windows.Data;
using LowBank.Windows.Models;
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
    public partial class Login : Form
    {
        const char BACKSPACE_CHAR = '\b';
        BaseCustomerRepository customerRepository;
        Customer customer;

        public Login()
        {
            customerRepository = new ApiCustomerRepository();
            InitializeComponent();
            
        }

        private void accountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBoxBase campoDeTexto)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(accountTextBox.Text, out long accountNumber))
            {
                return;
            }

            customer = customerRepository.GetCustomerOrDefault(accountNumber);

            if (customer == null)
            {
                return;
            }

            var home = new Home(customer, customerRepository);
            home.Show();

            home.FormClosed += (s, e) => customerRepository.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegisterNewUser(customerRepository);

            registrationForm.Show();
        }
    }
}
