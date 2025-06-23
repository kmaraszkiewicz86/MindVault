using MindVault.Presentation.ViewModels;

namespace MindVault.Presentation.Views;

public partial class AddNotePage : ContentPage
{
	public AddNotePage()
	{
		InitializeComponent();
		BindingContext = new AddNoteViewModel();
    }
}