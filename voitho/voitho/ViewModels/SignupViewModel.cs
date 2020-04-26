using System;
using System.Collections.Generic;
using System.Text;
using voitho.SQLite;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class SignupViewModel : BaseViewModel
    {
        public SignupVisualState VisualState { get; set; } = new SignupVisualState();

        public Command SignupCommand
        {
            get => new Command(
                execute: async () =>
                {
                    if (!string.IsNullOrWhiteSpace(VisualState.SignupEmail) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupUsername) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupPassword1) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupPassword2) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupCountry) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupCity) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupAddress) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupPostalCode) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupMobilePhone) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupFirstName) &&
                        !string.IsNullOrWhiteSpace(VisualState.SignupLastName))
                    {
                        if (VisualState.SignupPassword1 == VisualState.SignupPassword2)
                        {
                            await VisualState.SQLiteManager.InsertUser(new User(
                                VisualState.SignupUsername,
                                VisualState.SignupPassword1,
                                VisualState.SignupEmail,
                                VisualState.SignupFirstName,
                                VisualState.SignupLastName,
                                VisualState.SignupBirthDate,
                                VisualState.SignupCountry,
                                VisualState.SignupCity,
                                VisualState.SignupAddress,
                                VisualState.SignupPostalCode,
                                VisualState.SignupAddress,
                                0,true));
                            await App.Current.MainPage.Navigation.PushAsync(new SignupCompletedView());
                        }

                        else
                        {
                            await App.Current.MainPage.DisplayAlert("Error", "Your second password doesn't match the first one.", "OK");

                        }
                    }

                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "Please fill all the field above.", "OK");
                    }
                });
        }
    }
}
