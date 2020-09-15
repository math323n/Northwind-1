using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

using NT.Entities.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NT.Gui
{
    public static class Extensions
    {
        public static void ReplaceWith<T>(this ObservableCollection<T> observableCollection, IEnumerable<T> collection)
        {
            if(collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            observableCollection.Clear();
            foreach(T item in collection)
            {
                observableCollection.Add(item);
            }
        }

        /// <summary>
        /// Only get the original exception.
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static Exception GetOriginalException(this Exception ex)
        {
            return ex.InnerException == null ? ex : ex.InnerException.GetOriginalException();
        }

       


    }
}