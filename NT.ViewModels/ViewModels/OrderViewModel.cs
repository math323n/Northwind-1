using NT.DataAccess.Repos;
using NT.Entities.Models;
using NT.Gui;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace NT.ViewModels.ViewModels
{
    public class OrderViewModel : ViewModel, INotifyPropertyChanged
    {
        #region Fields
        private Orders selectedOrder;
        #endregion

        #region Constructor

        public OrderViewModel()
        {
            Orders = new ObservableCollection<Orders>();
        }
        #endregion

        #region Collections
        public ObservableCollection<Orders> Orders { get; set; }

        public Orders SelectedOrder
        {
            get
            {
                return selectedOrder;
            }

            set
            {
                selectedOrder = value;
                OnPropertyChanged(nameof(SelectedOrder));
            }
        }
        #endregion


        #region Methods


        /// <summary>
        /// Initializes all orders
        /// </summary>
        public void Initialize()
        {
            LoadAllOrders();
        }

        /// <summary>
        /// Loads all products
        /// </summary>
        private void LoadAllOrders()
        {
            OrderRepository orderRepository = new OrderRepository();
            IEnumerable<Orders> orders = (IEnumerable<Orders>)orderRepository.GetAllAsync();
            Orders.ReplaceWith(orders);
        }

        /// <summary>
        /// Deletes an order
        /// </summary>
        private void DeleteOrder()
        {
            // Needs implementing
            throw new NotImplementedException();

        }
        /// <summary>
        ///  Adds an order
        /// </summary>
        private void AddOrder()
        {
            // Needs implementing
            throw new NotImplementedException();

        }
        #endregion
    }
}