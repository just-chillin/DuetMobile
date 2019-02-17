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
	public partial class usersProfile : ContentPage
	{
		public usersProfile ()
		{
			InitializeComponent ();
		}

        private void uploadPhoto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void matches(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}