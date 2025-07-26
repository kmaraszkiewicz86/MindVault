using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MindVault.Presentation.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }
        public ICommand CheckAuthenticationCommand { get; }

        public virtual bool IsAuthenticated => false;

        public event PropertyChangedEventHandler? PropertyChanged;

        public BaseViewModel()
        {
            CheckAuthenticationCommand = new Command(async () =>
            {
                if (!IsAuthenticated)
                {
                    await Shell.Current.GoToAsync("//LoginPage");
                }
            });
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
