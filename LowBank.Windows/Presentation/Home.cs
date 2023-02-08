using LowBank.Windows.Models;
using LowBank.Windows.Data;
using System;


namespace LowBank.Windows.Presentation
{
    public partial class Home : Form
    {
        //Representa o caracter de backspace
        const char BACKSPACE_CHAR = '\b';

        BaseCustomerRepository customerRepository;
        Customer customer;

        public Home(Customer customer, BaseCustomerRepository customerRepository)
        {
            InitializeComponent();

            this.customerRepository = customerRepository;
            this.customer = customer;

            nameTextBox.Text = customer.Name;
            telefoneTextBox.Text = string.Format(@"{0:+00(00)#####-####}", customer.Telefone);
            emailTextbox.Text = customer.Email;
            accountTextBox1.Text = customer.Account.Id.ToString();
            CPFTextBox.Text = string.Format(@"{0:000\.###\.###\-##}", customer.CPF);
            ammountTextBox.Text = "R$: " + customer.Account.Amount.ToString();
            limitTextBox.Text = "R$: " + customer.Account.Limit.ToString();
        }


        private void AccountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBoxBase campoDeTexto)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }
        }


        private void transferButton_Click(object sender, EventArgs e)
        {
            AmmountTransfer form2 = new AmmountTransfer(customer, customerRepository);
            form2.Show();

            form2.FormClosed += (s, e) => customerRepository.LoadData();

        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegisterNewUser(customerRepository);
            registrationForm.Show();

            registrationForm.FormClosed += (s, e) => customerRepository.LoadData();
            
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            var amountDeposityForm = new deposityForm(customer, customerRepository);
            amountDeposityForm.Show();
        }

    }
}