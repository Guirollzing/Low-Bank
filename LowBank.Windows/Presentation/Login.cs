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

        public Login()
        {
            InitializeComponent();
            customerRepository = new ApiCustomerRepository();
            customerRepository.LoadData();
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
            var login = long.Parse(accountTextBox.Text);
            var password = passwordTextBox.Text;

            var loginmodel = new LoginModel(login, password);
            var isAutenticated = customerRepository.Login(loginmodel);

            if (isAutenticated)
            {
                var currentCustomer = customerRepository.GetCustomerOrDefault(login);
                var home = new Home(customerRepository, currentCustomer);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possível fazer login", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegisterNewUser(customerRepository);

            registrationForm.Show();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
