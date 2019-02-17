using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuetMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Survey : ContentPage
	{
		public Survey ()
		{
			InitializeComponent ();
		}

        private void usersProfile(object sender, EventArgs e)
        {
            //string music = 
           // string movies = movies.Text;
           // DisplayAlert("Values entered:", name + " " + pass, "ok");
            Navigation.PushAsync(new usersProfile());
        }
    }
}