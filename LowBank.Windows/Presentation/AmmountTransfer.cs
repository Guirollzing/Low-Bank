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

        BaseCustomerRepository customerRepository;
        Customer ownerCustomer;
        Customer transferCustomer;

        public AmmountTransfer(Customer customer, BaseCustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
            this.ownerCustomer = customer;
            InitializeComponent();
        }

        private void AmmountTransfer_Activated(object sender, EventArgs e)
        {
            nameClient1.Text = ownerCustomer.Name;
            emailClient1.Text = ownerCustomer.Email;
            telefoneClient1.Text = string.Format(@"{0:+00(00)#####-####}", ownerCustomer.Telefone);
            CPFClient1.Text = string.Format(@"{0:000\.###\.###\-##}", ownerCustomer.CPF);
            ammountClient1.Text = "R$: " + ownerCustomer.Account.Amount.ToString();
            limitTextBox.Text = "R$: " + ownerCustomer.Account.Limit.ToString();

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

            transferCustomer = customerRepository.GetCustomerOrDefault(accountNumber);

            if (ownerCustomer == null)
            {
                return;
            }

            nameCliente2.Text = transferCustomer.Name;
            emailClient2.Text = transferCustomer.Email;
            telefoneClient2.Text = string.Format(@"{0:+00(00)#####-####}", transferCustomer.Telefone);
            amountClient2.Text = transferCustomer.Account.Amount.ToString();          


        }


        private void transferValueButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (!decimal.TryParse(textBox2.Text, out amount))
            {
                amount = 0;
            }

            bool foiEfetuado = ownerCustomer.Account.Tranfer(transferCustomer.Account, amount);

            if (foiEfetuado)
            {
                customerRepository.UpDate(ownerCustomer, transferCustomer);

                MessageBox.Show($"Transferencia de R$: {amount} realizada com sucesso!");

                ammountClient1.Text = ownerCustomer.Account.Amount.ToString();
                amountClient2.Text = transferCustomer.Account.Amount.ToString();

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
