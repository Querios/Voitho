using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using voitho.SQLite;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class BaseVisualState : INotifyPropertyChanged
    {
        public BaseVisualState() { }

        public User ActiveUser => App.ActiveUser;
        public SQLiteManager SQLiteManager => App.SQLiteManager;

        protected bool _pIsBusy;
        public bool IsBusy
        {
            get
            {
                return _pIsBusy;
            }
            set
            {
                _pIsBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        #region PropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}