using System.Collections.ObjectModel;

namespace MindVault.Models.Dtos
{
    public class Category
    {
        public string Name { get; set; } = string.Empty;
        public ObservableCollection<Note> Notes { get; set; } = new();
    }
}
