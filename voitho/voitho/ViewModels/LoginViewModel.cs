using System;
using System.Collections.Generic;
using System.Text;
using voitho.SQLite;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginVisualState VisualState { get; set; } = new LoginVisualState();

        public Command LoginCommand
        {
            get => new Command(
                execute: async () =>
                {
                    if (VisualState.SQLiteManager.LoginTask(VisualState.LoginUsername, VisualState.LoginPassword).Result)
                    {
                        App.ActiveUser = VisualState.SQLiteManager.LastUserSearched;
                        await App.Current.MainPage.Navigation.PushAsync(new UserTypeView());
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "Login failed. Please try again.", "OK");
                    }
                    
                });
        }
    }
}

