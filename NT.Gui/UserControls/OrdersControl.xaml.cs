using NT.ViewModels.ViewModels;
using System;
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
        private bool isLoaded;

        public OrdersControl()
        {
            InitializeComponent();

            viewModel = DataContext as OrderViewModel;
        }

        /// <summary>
        ///  Run when loaded Controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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