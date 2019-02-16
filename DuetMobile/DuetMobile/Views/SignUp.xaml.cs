using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuetMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        private Label header;
        private Entry emailEntry;
        private Entry passwardEntry;
        private Button signInButton;


        public SignUp()
        {
            // set up header 
            StackLayout stackLayout = new StackLayout();
            header.Text = "Sign In Page";
            header.FontAttributes = FontAttributes.Bold;
            header.Margin = new Thickness(10, 10, 10, 10);
            header.HorizontalOptions = LayoutOptions.StartAndExpand;
            stackLayout.Children.Add(header);

            // set up email
            emailEntry = new Entry
            {
                Keyboard = Keyboard.Email,
                Placeholder = "School Email ID"
            };
            stackLayout.Children.Add(emailEntry);

            // set up password
            passwardEntry = new Entry
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Password",
                IsPassword = true
            };
            stackLayout.Children.Add(emailEntry);

            // set up the button 
            signInButton = new Button
            {
                Text = "Sign In"
            };
            signInButton.Clicked += SignInButtonClicked;
            stackLayout.Children.Add(signInButton);

            Content = stackLayout;


            InitializeComponent();

        }

        private void SignInButtonClicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwardEntry.Text;
        }
    }
}