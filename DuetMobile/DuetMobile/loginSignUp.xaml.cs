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
	public partial class loginSignUp : ContentPage
	{
		public loginSignUp ()
		{
			InitializeComponent ();
		}

        private void Enter_Clicked(object sender, EventArgs e)
        {
            // Get value of both entries (username and password)
            string name = username.Text;
            string pass = password.Text;

            // show the values for both variables using a popup
            DisplayAlert("Entries value", name + " " + pass, "ok");

        }
    }
}