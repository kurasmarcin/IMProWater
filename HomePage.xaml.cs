using Microsoft.Maui.Controls;

namespace IMProWater
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnSectionsButtonClicked(object sender, EventArgs e)
        {
            // Przekazujemy domy�lny numer sekcji, np. "1"
            await Navigation.PushAsync(new SectionsPage("1"));
        }

        private async void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Przejd� do strony Ustawienia
            await Navigation.PushAsync(new SettingsPage());
        }

        private async void OnStatusButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StatusPage());
        }
    }
}
