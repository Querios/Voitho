using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using voitho.SQLite;
using Xamarin.Forms;

namespace voitho.Interfaces
{
    public interface IUserListViewModel
    {
        IUserListVisualState VisualState { get; set; }

        Command ChangeSortOrderCommand { get; }

    }
}
