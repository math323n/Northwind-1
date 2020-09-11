using NT.DataAccess.Repos;
using NT.Entities.Models;
using NT.Gui;
using NT.Gui.ViewModels.Base;
using NT.Services;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace NT.ViewModels.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        #region Fields
        protected ObservableCollection<Orders> orders;
        protected Orders selectedOrder;
        #endregion

        #region Constructor
        public OrderViewModel()
        {
            Orders = new ObservableCollection<Orders>();
        }
        #endregion

        #region Properties
        public ObservableCollection<Orders> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                SetProperty(ref orders, value);
            }
        }

        public Orders SelectedOrder
        {
            get
            {
                return selectedOrder;
            }
            set
            {
                SetProperty(ref selectedOrder, value);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Loads all orders from the endpoint
        /// </summary>
        private new async Task LoadAllAsync()
        {
            OrderService service = new OrderService();

            List<Orders> orders = await service.GetAllOrdersAsync();

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