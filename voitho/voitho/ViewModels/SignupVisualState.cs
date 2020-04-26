using System;
using System.Collections.Generic;
using System.Text;

namespace voitho.ViewModels
{
    public class SignupVisualState : BaseVisualState
    {
        public SignupVisualState()
        {
            SignupBirthDate = DateTime.Today;
        }

        protected string _pSignupEmail;
        public string SignupEmail
        {
            get
            {
                return _pSignupEmail;
            }
            set
            {
                _pSignupEmail = value;
                OnPropertyChanged(nameof(SignupEmail));
            }
        }

        protected string _pSignupUsername;
        public string SignupUsername
        {
            get
            {
                return _pSignupUsername;
            }
            set
            {
                _pSignupUsername = value;
                OnPropertyChanged(nameof(SignupUsername));
            }
        }

        protected string _pSignupPassword1;
        public string SignupPassword1
        {
            get
            {
                return _pSignupPassword1;
            }
            set
            {
                _pSignupPassword1 = value;
                OnPropertyChanged(nameof(SignupPassword1));
            }
        }

        protected string _pSignupPassword2;
        public string SignupPassword2
        {
            get
            {
                return _pSignupPassword2;
            }
            set
            {
                _pSignupPassword2 = value;
                OnPropertyChanged(nameof(SignupPassword2));
            }
        }

        protected string _pSignupFirstName;
        public string SignupFirstName
        {
            get
            {
                return _pSignupFirstName;
            }
            set
            {
                _pSignupFirstName = value;
                OnPropertyChanged(nameof(SignupFirstName));
            }
        }

        protected string _pSignupLastName;
        public string SignupLastName
        {
            get
            {
                return _pSignupLastName;
            }
            set
            {
                _pSignupLastName = value;
                OnPropertyChanged(nameof(SignupLastName));
            }
        }

        protected string _pSignupCountry;
        public string SignupCountry
        {
            get
            {
                return _pSignupCountry;
            }
            set
            {
                _pSignupCountry = value;
                OnPropertyChanged(nameof(SignupCountry));
            }
        }

        protected string _pSignupCity;
        public string SignupCity
        {
            get
            {
                return _pSignupCity;
            }
            set
            {
                _pSignupCity = value;
                OnPropertyChanged(nameof(SignupCity));
            }
        }

        protected string _pSignupAddress;
        public string SignupAddress
        {
            get
            {
                return _pSignupAddress;
            }
            set
            {
                _pSignupAddress = value;
                OnPropertyChanged(nameof(SignupAddress));
            }
        }

        protected string _pSignupPostalCode;
        public string SignupPostalCode
        {
            get
            {
                return _pSignupPostalCode;
            }
            set
            {
                _pSignupPostalCode = value;
                OnPropertyChanged(nameof(SignupPostalCode));
            }
        }

        protected string _pSignupMobilePhone;
        public string SignupMobilePhone
        {
            get
            {
                return _pSignupMobilePhone;
            }
            set
            {
                _pSignupMobilePhone = value;
                OnPropertyChanged(nameof(SignupMobilePhone));
            }
        }

        protected DateTime _pSignupBirthDate;
        public DateTime SignupBirthDate
        {
            get
            {
                return _pSignupBirthDate;
            }
            set
            {
                _pSignupBirthDate = value;
                OnPropertyChanged(nameof(SignupBirthDate));
            }
        }

        public DateTime MaxDate => DateTime.Today;
        public DateTime MinDate => DateTime.Today.AddYears(-150);
    }
}
