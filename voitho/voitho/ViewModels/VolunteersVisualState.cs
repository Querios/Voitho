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
    public class VolunteersVisualState : BaseVisualState, IUserListVisualState
    {

        public VolunteersVisualState(int selectedSortChoice = 0)
        {
            UserList = SQLiteManager.GetAllUsers().Result;
            SelectedSortChoice = selectedSortChoice;
        }

        public List<SortOptions> SortOptionsList { get; set; } = new List<SortOptions>()
        {
            new SortOptions(SortOptionsEnum.Distance, "Sort by Distance"),
            new SortOptions(SortOptionsEnum.Rating, "Sort by Rating"),
            new SortOptions(SortOptionsEnum.Username, "Sort by Username"),
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
                OnPropertyChanged(nameof(SortedUserList));
            }
        }

        protected List<User> _UserList;
        public List<User> UserList
        {
            get
            {
                return _UserList;
            }
            set
            {
                value.RemoveAll(el => el.IsActiveUser == true);
                _UserList = value;
                OnPropertyChanged(nameof(UserList));
            }
        }

        protected ObservableCollection<User> _pSortedUserList;
        public ObservableCollection<User> SortedUserList
        {
            get
            {
                switch (SelectedSortChoice)
                {
                    case 0:
                        _pSortedUserList = new ObservableCollection<User>(UserList.OrderBy(el => el.Distance));
                        break;

                    case 1:
                        _pSortedUserList = new ObservableCollection<User>(UserList.OrderBy(el => el.Rating));
                        break;

                    default:
                        _pSortedUserList = new ObservableCollection<User>(UserList.OrderBy(el => el.Username));
                        break;

                }
                if (OrderByDescenting)
                {
                    _pSortedUserList = new ObservableCollection<User>(_pSortedUserList.Reverse());
                }

                OnPropertyChanged(nameof(NoResultsFound));
                return _pSortedUserList;
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
                OnPropertyChanged(nameof(SortedUserList));
            }
        }

        public FileImageSource ArrowImage => OrderByDescenting
            ? App.Current.Resources["DownArrowIcon"] as FileImageSource
            : App.Current.Resources["UpArrowIcon"] as FileImageSource;

        public bool NoResultsFound => _pSortedUserList == null || _pSortedUserList.Count == 0;
    }
}
