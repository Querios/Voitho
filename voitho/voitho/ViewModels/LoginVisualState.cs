using System;
using System.Collections.Generic;
using System.Text;

namespace voitho.ViewModels
{
    public class LoginVisualState: BaseVisualState
    {
        protected string _pLoginUsername;
        public string LoginUsername
        {
            get
            {
                return _pLoginUsername;
            }
            set
            {
                _pLoginUsername = value;
                OnPropertyChanged(nameof(LoginUsername));
            }
        }

        protected string _pLoginPassword;
        public string LoginPassword
        {
            get
            {
                return _pLoginPassword;
            }
            set
            {
                _pLoginPassword = value;
                OnPropertyChanged(nameof(LoginPassword));
            }
        }
    }
}
