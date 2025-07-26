using CommunityToolkit.Maui.Extensions;
using MindVault.Models.Dtos;
using MindVault.Presentation.Popups;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MindVault.Presentation.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Category> _categories = new();
        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set => SetProperty(ref _categories, value);
        }

        private Category _selectedCategory = default!;
        public Category SelectedCategory
        {
            get => _selectedCategory ?? new Category { Name = "Brak wybranej kategorii" };
            set => SetProperty(ref _selectedCategory, value);
        }

        private string _newCategoryName = string.Empty;
        public string NewCategoryName
        {
            get => _newCategoryName;
            set => SetProperty(ref _newCategoryName, value);
        }

        public ICommand ShowAddCategoryPopupCommand { get; }
        public ICommand AddCategoryCommand { get; }
        public ICommand NavigateToAddNoteCommand { get; }

        public MainViewModel()
        {
            ShowAddCategoryPopupCommand = new Command(ShowAddCategoryPopup);
            AddCategoryCommand = new Command(AddCategory);
            NavigateToAddNoteCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("AddNotePage");
            });
        }

        private void ShowAddCategoryPopup()
        {
            var popup = new AddCategoryPopup { BindingContext = this };
            Application.Current.MainPage.ShowPopup(popup);
        }

        private void AddCategory()
        {
            if (!string.IsNullOrWhiteSpace(NewCategoryName))
            {
                Categories.Add(new Category { Name = NewCategoryName });
                NewCategoryName = string.Empty;
            }
        }
    }

}
