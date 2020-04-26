using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace voitho.SQLite
{
    public class User: BaseClass
    {
        public User(string username, string password, string email, string firstName, string lastName, DateTime birthDate, string country, string city, string address, string postalCode, string phoneNumber, int rating = 0, bool isActiveUser = false)
        {
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Country = country;
            City = city;
            Address = address;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            Rating = rating;
            IsActiveUser = isActiveUser;
        }

        public User() { }

        protected int _pID;
        [PrimaryKey]
        [AutoIncrement]
        public int ID
        {
            get { return _pID; }
            set
            {
                _pID = value;
                OnPropertyChanged(nameof(ID));
                OnPropertyChanged(nameof(Distance));
                OnPropertyChanged(nameof(DistanceDisplay));
            }
        }

        protected string _pUsername;
        public string Username
        {
            get
            {
                return _pUsername;
            }
            set
            {
                _pUsername = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        protected string _pPassword;
        public string Password
        {
            get
            {
                return _pPassword;
            }
            set
            {
                _pPassword = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        protected string _pEmail;
        public string Email
        {
            get { return _pEmail; }
            set
            {
                _pEmail = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        protected string _pFirstName;

        public string FirstName
        {
            get { return _pFirstName; }
            set
            {
                _pFirstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        protected string _pLastName;

        public string LastName
        {
            get { return _pLastName; }
            set
            {
                _pLastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        protected DateTime _pBirthDate;

        public DateTime BirthDate
        {
            get { return _pBirthDate; }
            set
            {
                _pBirthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        protected string _pCountry;

        public string Country
        {
            get { return _pCountry; }
            set
            {
                _pCountry = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        protected string _pPostalCode;

        public string PostalCode
        {
            get { return _pPostalCode; }
            set
            {
                _pPostalCode = value;
                OnPropertyChanged(nameof(PostalCode));
                OnPropertyChanged(nameof(AddressPlusPostCode));
            }
        }

        protected string _pCity;

        public string City
        {
            get { return _pCity; }
            set
            {
                _pCity = value;
                OnPropertyChanged(nameof(City));
            }
        }

        protected string _pAddress;

        public string Address
        {
            get { return _pAddress; }
            set
            {
                _pAddress = value;
                OnPropertyChanged(nameof(Address));
                OnPropertyChanged(nameof(AddressPlusPostCode));
            }
        }

        protected string _pPhoneNumber;

        public string PhoneNumber
        {
            get { return _pPhoneNumber; }
            set
            {
                _pPhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        protected int _pRating;

        public int Rating
        {
            get { return _pRating; }
            set
            {
                _pRating = value;
                OnPropertyChanged(nameof(Rating));
                OnPropertyChanged(nameof(DisplayRanking));
            }
        }

        protected bool _pIsActiveUser;

        public bool IsActiveUser
        {
            get { return _pIsActiveUser; }
            set
            {
                _pIsActiveUser = value;
                OnPropertyChanged(nameof(IsActiveUser));
            }
        }

        [Ignore]
        public string FullName => FirstName + " " + LastName;

        [Ignore]
        public string AddressPlusPostCode => Address + ", " + PostalCode;

        [Ignore]
        public string DisplayRanking => "Rating: " + Rating;

        [Ignore]
        public float Distance => ID * 2;

        [Ignore]
        public string DistanceDisplay => Distance + " m";

    }
}
