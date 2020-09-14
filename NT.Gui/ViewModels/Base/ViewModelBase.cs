using System;
using System.Threading.Tasks;

namespace NT.Gui.ViewModels.Base
{
    /// <summary>
    /// Base class for ViewModel classes
    /// </summary>
    public abstract class ViewModelBase : BindableBase
    {
        #region Methods
        /// <summary>
        /// Loads data from the database
        /// Gets overriden inside OrderViewModel & ProductViewModel
        /// </summary>
        public virtual Task LoadAllAsync()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}