using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using voitho.SQLite;
using Xamarin.Forms;

namespace voitho.Interfaces
{
    public interface IUserListVisualState
    {
        ObservableCollection<User> SortedUserList { get; }

        int SelectedSortChoice { get; set; }

        bool OrderByDescenting { get; set; }

        FileImageSource ArrowImage { get; }

        bool NoResultsFound { get; }
    }
}
