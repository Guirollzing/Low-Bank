namespace LowBank_Mobile;

public partial class MainPage : ContentPage
{
    private readonly ApiCustomerRepository _customerRepository;

    public MainPage()
	{
		InitializeComponent();
        _customerRepository = new ApiCustomerRepository();
        
    }

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        var login = long.Parse(AccountEntry.Text);
        var password = PasswordEntry.Text;

        var loginmodel = new LoginModel(login, password);
        var exist = _customerRepository.Exists(login);
        var isAutenticated = _customerRepository.Login(loginmodel);

        if (isAutenticated)
        {
            await Shell.Current.GoToAsync("accountpage");
        }
        else
        {
            await this.DisplayAlert(
                "Erro",
                "Não foi possivel fazer login, conta incorreta!",
                "Entendi!");
        }

    }

    private async void SignBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("registrationpage");
    }
}

