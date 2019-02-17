using System;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuetMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class loginSignUp : ContentPage
    {
        public loginSignUp()
        {
            InitializeComponent();
        }

        private void Enter_Clicked(object sender, EventArgs e)
        {
            // Get value of both entries (username and password)
            string name = username.Text;
            string pass = password.Text;

            // show the values for both variables using a popup
            DisplayAlert("Values entered:", name + " " + pass, "ok"); // placeholder?

        }
        private void signUpProcedure(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Survey());
        }
    }

    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }
    }


}