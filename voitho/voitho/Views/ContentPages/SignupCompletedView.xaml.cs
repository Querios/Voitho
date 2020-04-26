using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace voitho.Views.ContentPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignupCompletedView : ContentPage
	{
		public SignupCompletedView ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        
    }
}