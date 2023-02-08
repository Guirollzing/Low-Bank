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
    public partial class deposityForm : Form
    {
        const char BACKSPACE_CHAR = '\b';

        BaseCustomerRepository customerRepository;
        Customer customer;
        public deposityForm(Customer customer, BaseCustomerRepository customerRepository)
        {
            InitializeComponent();
            this.customerRepository = customerRepository;
            this.customer = customer;
        }

        private void deposityForm_Activated(object sender, EventArgs e)
        {
            nameTextBox.Text = customer.Name;
            emailTextBox.Text = customer.Email;
            CPFTextBox.Text = customer.CPF.ToString();
            telefoneTextBox.Text = customer.Telefone.ToString();
            acountNumberTextBox.Text = customer.Account.Id.ToString();
        }

        private void amountToTranfersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBoxBase campoDeTexto)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (!decimal.TryParse(amountToTranfersTextBox.Text, out amount))
            {
                amount = 0;
            }

            bool foiEfetuado = customer.Account.Deposity(customer.Account, amount);

            if (foiEfetuado)
            {
                customerRepository.UpDate(customer);

                MessageBox.Show($"Depósito de R$: {amount} realizado com sucesso!");


                Close();
            }
            else
            {
                MessageBox.Show("Depósito não realizado!", "Erro!", MessageBoxButtons.OK);
            }
        }
    }
}
