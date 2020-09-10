using NT.DataAccess.Repos;
using NT.ViewModels.ViewModels;

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NT.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for OrdersControl.xaml
    /// </summary>
    public partial class OrdersControl: UserControl
    {
        #region Fields
        readonly OrderViewModel orderViewModel;
        OrderRepository repo;
        private bool isLoaded;


        #endregion


        public OrdersControl()
        {
            InitializeComponent();
            repo = new OrderRepository();
            orderViewModel = DataContext as OrderViewModel;
        }



        #region Methods
        /// <summary>
        /// Is run when UserControl is loaded once
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if(!isLoaded)
            {
                isLoaded = true;
                orderViewModel.Initialize();
            }
        }

        #endregion
    }
}
