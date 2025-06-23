using System.Windows.Input;

namespace MindVault.Presentation.ViewModels
{
    public class AddNoteViewModel : BaseViewModel
    {
        private string _noteTitle = string.Empty;
        public string NoteTitle
        {
            get => _noteTitle;
            set => SetProperty(ref _noteTitle, value);
        }

        private string _content = string.Empty;

        public string Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        public ICommand CancelNoteCommand { get; }
        public ICommand SaveNoteCommand { get; }

        public AddNoteViewModel()
        {
            SaveNoteCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("..");
            });

            CancelNoteCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("..");
            });
        }
    }

}
