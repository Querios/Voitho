using System;
using System.Collections.Generic;
using System.Text;
using voitho.Views.ContentPages;
using Xamarin.Forms;

namespace voitho.ViewModels
{
    public class OfferHelpViewModel: BaseViewModel
    {
        public OfferHelpVisualState VisualState { get; set; } = new OfferHelpVisualState();

        public Command OpenHelpersView
        {
            get => new Command(
                execute: async () =>
                {
                    await App.Current.MainPage.Navigation.PushAsync(new RequestsView());
                });
        }
    }
}
