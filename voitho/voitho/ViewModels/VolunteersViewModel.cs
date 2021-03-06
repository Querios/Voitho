﻿using System;
using System.Collections.Generic;
using System.Text;
using voitho.Interfaces;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class VolunteersViewModel : BaseViewModel, IUserListViewModel
    {
        public IUserListVisualState VisualState { get; set; } = new VolunteersVisualState();

        public Command ChangeSortOrderCommand
        {
            get => new Command(
                execute: async () => { VisualState.OrderByDescenting = !VisualState.OrderByDescenting; });
        }

        public Command ReturnToUserTypeViewCommand
        {
            get => new Command(
                execute: async () =>
                {
                        App.Current.MainPage = new NavigationPage(new UserTypeView());
                    
                });
        }

    }
}
