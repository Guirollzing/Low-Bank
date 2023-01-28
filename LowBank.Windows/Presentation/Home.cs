using LowBank.Windows.Models;
using LowBank.Windows.Data;
using System;


namespace LowBank.Windows.Presentation
{
    public partial class Home : Form
    {
        //Representa o caracter de backspace
        const char BACKSPACE_CHAR = '\b';

        CustomerRepository customerRepository;        

        public Home()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
            customerRepository.LoadData();
        }


        private void AccountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (sender is TextBoxBase campoDeTexto)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(accountTextbox.Text, out long accountNumber))
            {
                return;
            }

            Customer cliente = customerRepository.GetCustomerOrDefault(accountNumber);

            if (cliente == null)
            {
                return;
            }

            transferButton.Visible = true;

            nameTextBox.Text = cliente.Name;
            telefoneTextBox.Text = string.Format(@"{0:+00(00)#####-####}", cliente.Telefone);
            emailTextbox.Text = cliente.Email;
            accountTextBox1.Text = cliente.Account.Id.ToString();
            CPFTextBox.Text = string.Format(@"{0:000\.###\.###\-##}", cliente.CPF);
            ammountTextBox.Text = "R$: " + cliente.Account.Amount.ToString();
                        

        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            AmmountTransfer form2 = new AmmountTransfer();
            form2.Show();
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegisterNewUser(customerRepository);
            registrationForm.Show();

            registrationForm.FormClosed += (s, e) => customerRepository.LoadData();
            
        }


    }
}