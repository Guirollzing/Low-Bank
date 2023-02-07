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
using LowBank.Windows.Data;

namespace LowBank.Windows.Presentation
{
    public partial class RegisterNewUser : Form
    {
        BaseCustomerRepository customerRepository;

        public RegisterNewUser(BaseCustomerRepository repository)
        {
            customerRepository = repository;
            InitializeComponent();
            ResetErrorLabels();
        }        

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            isValid &= IsValid(nameRegister.Text, nameErrorLabel);
            isValid &= IsValid(emailRegister.Text, nameErrorLabel);
            isValid &= IsValid(telefoneRegister.Text, nameErrorLabel);
            isValid &= IsValid(CPFRegister.Text, nameErrorLabel);
                        
            if (!isValid)
            {
                return;
            }

            
            //Validar o CPF contra duplicidade
            long cpf = Convert.ToInt64(CPFRegister.Text);
            bool isDuplicade = customerRepository.Exists(cpf);

            if (isDuplicade)
            {
                MessageBox.Show($" CPF {cpf:000\\.###\\.###\\-##} já cadastrado!",
                    "Erro de cadastro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            long telefone = Convert.ToInt64(telefoneRegister.Text);

            Customer newCustomer = new Customer(nameRegister.Text, emailRegister.Text, cpf, telefone);
            int novoNumeroConta = customerRepository.Save(newCustomer);

            this.Close();

            MessageBox.Show($"Usuario conta {novoNumeroConta} cadastrado com sucesso!");
        }

        private bool IsValid(string text, Label errorLabel)
        {
            if (string.IsNullOrWhiteSpace(nameRegister.Text))
            {
                errorLabel.Visible = true;
                return false;
            }

            return true;
        }

        private void telefoneRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CPFRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            ResetErrorLabels();
        }

        private void ResetErrorLabels()
        {
            nameErrorLabel.Visible = false;
            emailErrorLabel.Visible = false;
            CPFErrorLabel.Visible = false;
            telefoneErrorLabel.Visible = false;
        }
    }
}
