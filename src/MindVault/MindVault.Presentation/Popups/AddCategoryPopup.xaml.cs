using MindVault.Presentation.ViewModels;

namespace MindVault.Presentation.Popups;

public partial class AddCategoryPopup : ContentView
{
	public AddCategoryPopup()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }
}