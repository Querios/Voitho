using System;
using System.Collections.Generic;
using System.Text;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public WelcomeVisualState VisualState { get; set; } = new WelcomeVisualState();

        public Command OpenLoginViewCommand
        {
            get => new Command(
                   execute: async () => { await App.Current.MainPage.Navigation.PushAsync(new LoginView()); });
        }

        public Command OpenSignupViewCommand
        {
            get => new Command(
                execute: async () => { await App.Current.MainPage.Navigation.PushAsync(new SignupView()); });
        }
    }
}
