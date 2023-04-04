using LowBank_Mobile.ViewModels;

namespace LowBank_Mobile;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
        InitializeComponent();
        BindingContext = new AccountViewModel();
    }
}