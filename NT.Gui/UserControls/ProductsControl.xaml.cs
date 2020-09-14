using NT.ViewModels.ViewModels;

using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace NT.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for ProductsControl.xaml
    /// </summary>
    public partial class ProductsControl: UserControl
    {
        private readonly ProductViewModel viewModel;
        private bool isLoaded;

        public ProductsControl()
        {
            InitializeComponent();

            viewModel = DataContext as ProductViewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // If not loaded then run
                if(!isLoaded)
                {
                    // Set isLoaded to True
                    isLoaded = !isLoaded;

                    await viewModel.LoadAllAsync();
                }
            }
            catch(Exception)
            { 
                // Error displayed on GUI
                MessageBox.Show($"Could not establish connection with DataBase", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}