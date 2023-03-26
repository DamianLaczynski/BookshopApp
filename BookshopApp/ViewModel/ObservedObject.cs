using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BookshopApp.ViewModel
{
    public abstract class ObservedObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(params string[] propertyNames)
        {
            if(PropertyChanged != null)
            {
                foreach (var property in propertyNames)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }
    }
}
