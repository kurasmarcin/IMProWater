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
                await DisplayAlert("Sukces", "Zalogowano pomy�lnie!", "OK");
                // Przejd� do strony g��wnej dla zalogowanych u�ytkownik�w
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("B��d", "Nieprawid�owy email lub has�o", "OK");
            }
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
