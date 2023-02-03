using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LowBank.Windows.Data;
using LowBank.Windows.Models;

namespace LowBank.Windows.Presentation
{
    public partial class AmmountTransfer : Form
    {
        const char BACKSPACE_CHAR = '\b';

        CustomerRepository customerRepository;
        Customer customer;
        Customer customer1;

        public AmmountTransfer(Customer customer, CustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
            this.customer = customer;
            InitializeComponent();
        }

        private void AmmountTransfer_Activated(object sender, EventArgs e)
        {
            nameClient1.Text = customer.Name;
            emailClient1.Text = customer.Email;
            telefoneClient1.Text = string.Format(@"{0:+00(00)#####-####}", customer.Telefone);
            CPFClient1.Text = string.Format(@"{0:000\.###\.###\-##}", customer.CPF);
            ammountClient1.Text = "R$: " + customer.Account.Amount.ToString();


        }

        private void numberAccounClient2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBoxBase campoDeTexto)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }
        }

        private void numberAccounClient2_Leave(object sender, EventArgs e)
        {
            if (!long.TryParse(numberAccounClient2.Text, out long accountNumber))
            {
                return;
            }

            customer1 = customerRepository.GetCustomerOrDefault(accountNumber);

            if (customer == null)
            {
                return;
            }

            nameCliente2.Text = customer1.Name;
            emailClient2.Text = customer1.Email;
            telefoneClient2.Text = string.Format(@"{0:+00(00)#####-####}", customer1.Telefone);
            amountClient2.Text = customer1.Account.Amount.ToString();


        }


        private void transferValueButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (!decimal.TryParse(textBox2.Text, out amount))
            {
                amount = 0;
            }

            bool foiEfetuado = customer.Account.Tranfer(customer1.Account, amount);

            if (foiEfetuado)
            {
                customerRepository.UpDate(customer, customer1);

                MessageBox.Show($"Transferencia de R$: {amount} realizada com sucesso!");

                ammountClient1.Text = customer.Account.Amount.ToString();
                amountClient2.Text = customer1.Account.Amount.ToString();

                Close();
            }
            else
            {
                MessageBox.Show("Tranferencia não realizada!", "Erro!", MessageBoxButtons.OK);
            }                      

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBoxBase campoDeTexto)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }
        }


    }
}
