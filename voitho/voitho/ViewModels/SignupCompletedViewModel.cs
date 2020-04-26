using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class SignupCompletedViewModel : BaseViewModel
    {
        public SignupCompletedVisualState VisualState { get; set; } = new SignupCompletedVisualState();

        public SignupCompletedViewModel()
        {
            SimulateAuthorizationCommand.Execute(null);
        }

        public Command SimulateAuthorizationCommand
        {
            get => new Command(
                execute: async () =>
                {
                    await Task.Delay(2000);
                    VisualState.TitleMessage = "YOUR ACCOUNT HAS BEEN AUTHORIZED!";
                    VisualState.DescriptionMessage = "Your account has been authorized by your local authorities." +
                                                     "Please log in to start using the app.";
                    VisualState.IsUserVerified = true;
                });
        }

        public Command OpenLoginViewCommand
        {
            get => new Command(
                execute: async () =>
                {
                    var mainPage = new NavigationPage(new WelcomeView());
                    mainPage.Navigation.PushAsync(new LoginView());
                    App.Current.MainPage = mainPage;
                });
        }
    }
}
