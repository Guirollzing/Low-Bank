namespace LowBank.Windows
{
    public partial class Home : Form
    {
        const char BACKSPACE_CHAR = '\b';

        List<Account> ContasDeClientes;
        public Home()
        {
            InitializeComponent();
            ContasDeClientes = new List<Account>();

            Account contaDoGui = new Account(123456);
            ContasDeClientes.Add(contaDoGui);

            Account contaDoIgor = new Account(987654);
            ContasDeClientes.Add(contaDoIgor);

            Account contaDoFelipe = new Account(963852);
            ContasDeClientes.Add(contaDoFelipe);
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (sender is TextBoxBase campoDeTexto)
            {                
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE_CHAR;
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int accountNumber = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < ContasDeClientes.Count; i++)
            {
                Account contaAtual = ContasDeClientes[i];
                bool ehAContaQueQueremos = contaAtual.Id == accountNumber;

                if (ehAContaQueQueremos)
                {
                    decimal amount = contaAtual.Amount;
                    break;
                }
            }
        }
    }
}