using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad4dasya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text?.Trim();
            string password = PasswordEntry.Text?.Trim();

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                ErrorLabel.Text = "Please enter username and password";
                ErrorLabel.IsVisible = true;
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                ErrorLabel.Text = "Please enter username";
                ErrorLabel.IsVisible = true;
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                ErrorLabel.Text = "Please enter password";
                ErrorLabel.IsVisible = true;
                return;
            }

            ErrorLabel.IsVisible = false;

            await Navigation.PushAsync(new MainPage(username));
        }

        private async void OnForgotTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Forgot Password", "Please contact support to reset your password.", "OK");
        }
    }
}
