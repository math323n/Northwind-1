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

        /// <summary>
        ///  Run when loaded Controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!isLoaded)
                {
                    isLoaded = !isLoaded;

                    await viewModel.LoadAllAsync();
                }
            }
            catch(Exception ex)
            {
                Exception originalException = ex.GetOriginalException();

                MessageBox.Show(originalException.Message, "Kunne ikke oprette forbindelse til databasen.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}