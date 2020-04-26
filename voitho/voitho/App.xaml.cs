using System;
using voitho.SQLite;
using voitho.Views.ContentPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace voitho
{
    public partial class App : Application
    {
        public static SQLiteManager SQLiteManager { get; set; }
        public static User ActiveUser { get; set; }

        public App()
        {
            InitializeComponent();

            SQLiteManager = new SQLiteManager();

            NavigationPage.SetHasNavigationBar(this, false);

            if (SQLiteManager.ActiveUserExists().Result)
            {
                ActiveUser = SQLiteManager.GetActiveUser().Result;
                MainPage = new NavigationPage(new UserTypeView());
            }

            else
            {
                MainPage = new NavigationPage(new WelcomeView());
            }

            //MainPage = new NavigationPage(new VolunteersView());
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
