using MindVault.Presentation.ViewModels;

namespace MindVault.Presentation.Views;

public partial class NotesListView : ContentView
{
	public NotesListView()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }
}