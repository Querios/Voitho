using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public Command BackCommand
        {
            get => new Command(
            execute: async () =>
            {
                await App.Current.MainPage.Navigation.PopAsync();
            });
        }

        public Command LogoutCommand
        {
            get => new Command(
                execute: async () =>
                {
                    if (await App.SQLiteManager.DisableActiveUser())
                    {
                        App.Current.MainPage = new NavigationPage(new WelcomeView());
                    }
                });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
