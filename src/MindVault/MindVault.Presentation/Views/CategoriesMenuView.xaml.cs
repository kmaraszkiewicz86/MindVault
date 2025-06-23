using MindVault.Presentation.ViewModels;

namespace MindVault.Presentation.Views;

public partial class CategoriesMenuView : ContentView
{
	public CategoriesMenuView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
    }
}