using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NT.ViewModels.ViewModels
{
    public class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Method for notifying updates to a ViewModel property e.g SelectedItem
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}