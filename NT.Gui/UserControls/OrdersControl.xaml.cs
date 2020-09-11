using NT.ViewModels.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NT.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for OrdersControl.xaml
    /// </summary>
    public partial class OrdersControl: UserControl
    {
        private readonly OrderViewModel viewModel;

        public OrdersControl()
        {
            InitializeComponent();

            viewModel = DataContext as OrderViewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await viewModel.InitializeAsync();
        }
    }
}