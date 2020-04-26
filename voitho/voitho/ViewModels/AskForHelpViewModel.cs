using System;
using System.Collections.Generic;
using System.Text;
using voitho.SQLite;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class AskForHelpViewModel: BaseViewModel
    {
        public AskForHelpVisualState VisualState { get; set; } = new AskForHelpVisualState();

        public Command OpenVolunteersView
        {
            get => new Command(
                execute: async () =>
                {
                    if (VisualState.SelectedIndex > 0)
                    {
                        await VisualState.SQLiteManager.InsertRequest(
                            new Request(
                                VisualState.ActiveUser.ID,
                                VisualState.CategoriesList[VisualState.SelectedIndex].CategoryId,
                                VisualState.Comment));
                        await App.Current.MainPage.Navigation.PushAsync(new VolunteersView());
                    }
                    
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "Please choose a category.", "OK");
                    }
                });
        }
    }
}
