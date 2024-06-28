using Microsoft.Maui.Controls;
using System;
using IMProWater.Data;

namespace IMProWater
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            var user = await Database.DatabaseInstance.Table<User>()
                             .Where(u => u.Email == email && u.Password == password)
                             .FirstOrDefaultAsync();

            if (user != null)
            {
                await DisplayAlert("Sukces", "Zalogowano pomyœlnie!", "OK");
                // PrzejdŸ do strony g³ównej dla zalogowanych u¿ytkowników
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("B³¹d", "Nieprawid³owy email lub has³o", "OK");
            }
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
