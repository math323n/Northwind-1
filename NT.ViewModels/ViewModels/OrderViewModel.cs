using System;

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
            // Needs implementing
            throw new NotImplementedException();
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