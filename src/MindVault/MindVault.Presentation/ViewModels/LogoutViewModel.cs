using System.Threading.Tasks;
using System.Windows.Input;

namespace MindVault.Presentation.ViewModels
{
    public class LogoutViewModel : BaseViewModel
    {
        public ICommand LogoutCommand { get; }

        public LogoutViewModel()
        {
            LogoutCommand = new Command(async () => await LogoutAsync());
        }

        public async Task LogoutAsync()
        {
            // TODO: Add logout logic here (e.g., clear credentials, tokens, etc.)
            await Task.CompletedTask;
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
