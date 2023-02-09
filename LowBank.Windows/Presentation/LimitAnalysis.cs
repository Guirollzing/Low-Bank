using LowBank.Windows.Data;
using LowBank.Windows.Models;

namespace LowBank.Windows.Presentation
{
    public partial class LimitAnalysis : Form
    {
        private readonly Customer _customer;
        private readonly BaseCustomerRepository _repository;

        public LimitAnalysis(Customer customer, BaseCustomerRepository customerRepository)
        {
            _repository = customerRepository;
            _customer = customer;

            InitializeComponent();

            nameTextBox.Text = customer.Name;
            telefoneTextBox.Text = string.Format(@"{0:+00(00)#####-####}", customer.Telefone);
            emailTextbox.Text = customer.Email;
            accountTextBox1.Text = customer.Account.Id.ToString();
            CPFTextBox.Text = string.Format(@"{0:000\.###\.###\-##}", customer.CPF);
            ammountTextBox.Text = "R$: " + customer.Account.Amount.ToString();
            limitTextBox.Text = "R$: " + customer.Account.Limit.ToString();
        }

        private void SolicitarLimite_Click(object sender, EventArgs e)
        {
            // Analise de credito
            var analise = new Random();
            var result = analise.Next(-100, 200);

            // Verificar resultado da analise

            if (result > 0)
            {
                // Atualizar o banco de dados se necessario
                var oldLimit = _customer.Account.Limit;
                _customer.Account.Limit += result;
                _repository.UpDate(_customer);
                MessageBox.Show($"Seu limite foi alterado de R$ {oldLimit} para R$ {_customer.Account.Limit}!", "Análise de limite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Limite recusado, tente novamente mais tarde", "Análise de limite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
