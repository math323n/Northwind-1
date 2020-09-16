using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Windows;

namespace NT.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {

        public MainWindow()
        {
            Logger.Logger.Configure();
            InitializeComponent();
        }

 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  _logger.LogInformation("sut");
            MessageBox.Show("Added successfully", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}