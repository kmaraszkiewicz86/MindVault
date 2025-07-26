using MindVault.Presentation.ViewModels;

namespace MindVault.Presentation.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}