using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using voitho.Interfaces;
using voitho.SQLite;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class RequestsVisualState : BaseVisualState
    {
        public RequestsVisualState(int selectedSortChoice = 0)
        {
            UserList = SQLiteManager.GetAllUsers().Result;
            SelectedSortChoice = selectedSortChoice;
        }

        public List<SortOptions> SortOptionsList { get; set; } = new List<SortOptions>()
        {
            new SortOptions(SortOptionsEnum.Type, "Sort by Request Type")
        };

        protected int _pSelectedSortChoice;
        public int SelectedSortChoice
        {
            get
            {
                return _pSelectedSortChoice;
            }
            set
            {
                _pSelectedSortChoice = value;
                OnPropertyChanged(nameof(SelectedSortChoice));
                OnPropertyChanged(nameof(SortedRequestList));
            }
        }

        protected List<Request> _RequestList;
        public List<Request> RequestList
        {
            get
            {
                return _RequestList;
            }
            set
            {
                value.RemoveAll(el => el.RequesterId == ActiveUser.ID);
                _RequestList = value;
                OnPropertyChanged(nameof(RequestList));
            }
        }

        protected List<User> _pUserList;
        public List<User> UserList
        {
            get
            {
                return _pUserList;
            }
            set
            {
                value.RemoveAll(el => el.IsActiveUser == true);
                _pUserList = value;
                OnPropertyChanged(nameof(UserList));
                RequestList = SQLiteManager.GetAllRequests().Result;
            }
        }

        protected ObservableCollection<Request> _pSortedRequestList;
        public ObservableCollection<Request> SortedRequestList
        {
            get
            {
                //Should add more sort choices later
                _pSortedRequestList = new ObservableCollection<Request>(RequestList.OrderBy(el => el.ProblemCategory));

                if (OrderByDescenting)
                {
                    _pSortedRequestList = new ObservableCollection<Request>(_pSortedRequestList.Reverse());
                }

                OnPropertyChanged(nameof(NoResultsFound));
                return _pSortedRequestList;
            }
        }

        protected bool _pOrderByDescenting;
        public bool OrderByDescenting
        {
            get
            {
                return _pOrderByDescenting;
            }
            set
            {
                _pOrderByDescenting = value;
                OnPropertyChanged(nameof(OrderByDescenting));
                OnPropertyChanged(nameof(ArrowImage));
                OnPropertyChanged(nameof(SortedRequestList));
            }
        }

        public FileImageSource ArrowImage => OrderByDescenting
            ? App.Current.Resources["DownArrowIcon"] as FileImageSource
            : App.Current.Resources["UpArrowIcon"] as FileImageSource;

        public bool NoResultsFound => _pSortedRequestList == null || _pSortedRequestList.Count == 0;
    }
}
