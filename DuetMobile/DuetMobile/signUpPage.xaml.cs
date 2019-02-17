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
    public partial class signUpPage : ContentPage
    {
        public signUpPage()
        {
            InitializeComponent();
        }
        private void accountCreated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Survey());
        }

    }
}