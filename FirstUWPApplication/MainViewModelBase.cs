using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWPApplication
{
    public abstract class MainViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string typeChanged) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(typeChanged));
        }
    }
}
