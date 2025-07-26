using MindVault.Presentation.ViewModels;

namespace MindVault.Presentation.Views;

public partial class LogoutPage : ContentPage
{
    public LogoutPage()
    {
        InitializeComponent();
        BindingContext = new LogoutViewModel();
    }
}
