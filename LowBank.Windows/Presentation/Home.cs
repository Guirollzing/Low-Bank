using LowBank.Windows.Models;
using LowBank.Windows.Data;
using System;


namespace LowBank.Windows.Presentation
{
    public partial class Home : Form
    {
        //Representa o caracter de backspace
        const char BACKSPACE_CHAR = '\b';

        private BaseCustomerRepository customerRepository;
        private Customer currentCustomer;

        public Home(BaseCustomerRepository customerRepository, Customer currentCustomer)
        {
            this.currentCustomer = currentCustomer;
            this.customerRepository = customerRepository;
            InitializeComponent();
            FillFields();
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
            AmmountTransfer form2 = new AmmountTransfer(currentCustomer, customerRepository);
            form2.FormClosed += ReloadHome;

            form2.Show();
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegisterNewUser(customerRepository);
            registrationForm.FormClosed += ReloadHome;
            
            registrationForm.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            var amountDeposityForm = new deposityForm(currentCustomer, customerRepository);
            amountDeposityForm.FormClosed += ReloadHome;

            amountDeposityForm.Show();
        }

        private void AlterarLimite_Click(object sender, EventArgs e)
        {
            var limitAnalysisForm = new LimitAnalysis(currentCustomer, customerRepository);
            limitAnalysisForm.FormClosed += ReloadHome;

            limitAnalysisForm.Show();
        }

        private void ReloadHome(object? sender, FormClosedEventArgs e)
        {
            customerRepository.LoadData();
            FillFields();
        }

        private void FillFields()
        {
            nameTextBox.Text = currentCustomer.Name;
            telefoneTextBox.Text = string.Format(@"{0:+00(00)#####-####}", currentCustomer.Telefone);
            emailTextbox.Text = currentCustomer.Email;
            accountTextBox1.Text = currentCustomer.Account.Id.ToString();
            CPFTextBox.Text = string.Format(@"{0:000\.###\.###\-##}", currentCustomer.CPF);
            ammountTextBox.Text = "R$: " + currentCustomer.Account.Amount.ToString();
            limitTextBox.Text = "R$: " + currentCustomer.Account.Limit.ToString();
        }
    }
}