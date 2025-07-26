using MindVault.Presentation.ViewModels;

namespace MindVault.Presentation.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}
