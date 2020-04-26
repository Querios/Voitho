using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace voitho.ViewModels
{
    public class SignupCompletedVisualState : BaseVisualState
    {
        public SignupCompletedVisualState()
        {
            TitleMessage = "ACCOUNT HAS BEEN SUCCESSFULLY CREATED!";
            DescriptionMessage = "Your account has been successfully created. " +
                                 "We have sent you an email inbox for your verification email. " +
                                 "Afterwards please wait for the local authorities to validate your data.";
        }

        protected string _pTitleMessage;
        public string TitleMessage
        {
            get
            {
                return _pTitleMessage;
            }
            set
            {
                _pTitleMessage = value;
                OnPropertyChanged(nameof(TitleMessage));
            }
        }

        protected string _pDescriptionMessage;
        public string DescriptionMessage
        {
            get
            {
                return _pDescriptionMessage;
            }
            set
            {
                _pDescriptionMessage = value;
                OnPropertyChanged(nameof(DescriptionMessage));
            }
        }

        protected bool _pIsUserVerified;
        public bool IsUserVerified
        {
            get
            {
                return _pIsUserVerified;
            }
            set
            {
                _pIsUserVerified = value;
                OnPropertyChanged(nameof(IsUserVerified));
            }
        }
    }
}
