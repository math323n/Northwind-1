using System;
using System.Collections.Generic;
using System.Text;

namespace NT.ViewModels.ViewModels
{
    public class OrderViewModel
    {
        #region Fields
        #endregion


        #region Constructor

        public OrderViewModel()
        {

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
            throw new NotImplementedException();
        }

        private void DeleteOrder()
        {
            throw new NotImplementedException();

        }
        private void AddOrder()
        {
            throw new NotImplementedException();

        }
        #endregion
    }
}