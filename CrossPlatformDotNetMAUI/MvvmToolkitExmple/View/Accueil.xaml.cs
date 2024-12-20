using Microsoft.Maui.Controls;

namespace MvvmToolkitExmple.View
{
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            InitializeComponent(); 
        }


        private async void OnCalculButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//AnimalPage");
        }

        private async void OnCalculButtonClickedWeather(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//RandomWeatherPage");
        }
    }
}
