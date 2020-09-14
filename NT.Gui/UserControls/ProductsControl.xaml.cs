﻿using NT.ViewModels.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace NT.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for ProductsControl.xaml
    /// </summary>
    public partial class ProductsControl : UserControl
    {
        private readonly ProductViewModel viewModel;

        public ProductsControl()
        {
            InitializeComponent();

            viewModel = DataContext as ProductViewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                await viewModel.LoadAllAsync();
            }
            catch(Exception)
            {
               
            }
        }
    }
} 