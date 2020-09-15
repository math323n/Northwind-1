using Microsoft.Extensions.Logging.Console;

using NT.ViewModels.ViewModels;

using System;
using System.Globalization;
using System.IO;
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
        #region Fields
        private readonly ProductViewModel viewModel;
        private bool isLoaded;
        #endregion

        #region Constructor
        /// <summary>
        /// ProductsControl Constructor
        /// </summary>
        public ProductsControl()
        {
            InitializeComponent();

            viewModel = DataContext as ProductViewModel;
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
                // Log error message to a text document
                // get file path
                string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                string filePath = $"{directory}/log.txt";
                // Use StreamWriter to log message
                using(StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Write...
                    writer.WriteLine("Message :" + ex.Message  + Environment.NewLine + "StackTrace :" + ex.StackTrace +
                       "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                    // Make space for new message
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
                }
                Exception originalException = ex.GetOriginalException();

                MessageBox.Show(originalException.Message, "Kunne ikke oprette forbindelse til databasen.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion
    }
}