using System;
using System.Collections.Generic;
using System.Text;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class UserTypeViewModel : BaseViewModel
    {
        public  UserTypeVisualState VisualState { get; set; } = new UserTypeVisualState();

        public Command OpenAskForHelpViewCommand
        {
            get => new Command(
                execute: async () => { await App.Current.MainPage.Navigation.PushAsync(new AskHelpView()); });
        }

        public Command OpenOfferHelpViewCommand
        {
            get => new Command(
                execute: async () => { await App.Current.MainPage.Navigation.PushAsync(new OfferHelpView()); });
        }
    }
}
