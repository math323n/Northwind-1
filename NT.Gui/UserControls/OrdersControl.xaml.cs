using NT.Utilities;
using NT.ViewModels.ViewModels;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace NT.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for OrdersControl.xaml
    /// </summary>
    public partial class OrdersControl: UserControl
    {
        #region Fields
        private readonly OrderViewModel viewModel;
        private bool isLoaded;
        #endregion

        #region Constructor
        /// <summary>
        /// OrdersControl constructor
        /// </summary>
        public OrdersControl()
        {
            InitializeComponent();

            viewModel = DataContext as OrderViewModel;
        }
        #endregion

        #region Methods
        /// <summary>
        ///  Run when loaded Controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check if isLoaded is false
                if(!isLoaded)
                {
                    // Set isLoaded to true
                    isLoaded = !isLoaded;

                    await viewModel.LoadAllAsync();
                }
            }
            catch(Exception ex)
            {
                Logger.Logger.Log(ex);
                Exception originalException = ex.GetOriginalException();

                MessageBox.Show(originalException.Message, "Kunne ikke oprette forbindelse til databasen.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion
    }
}