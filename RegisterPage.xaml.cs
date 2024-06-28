using Microsoft.Maui.Controls;
using System;
using IMProWater.Data;

namespace IMProWater
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = EmailEntry.Text;

            var user = new User { Email = email, Password = password };
            await Database.DatabaseInstance.InsertAsync(user);

            await DisplayAlert("Sukces", "Rejestracja zako�czona pomy�lnie!", "OK");
            // Przejd� do strony g��wnej dla zalogowanych u�ytkownik�w
            await Navigation.PushAsync(new HomePage());
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
