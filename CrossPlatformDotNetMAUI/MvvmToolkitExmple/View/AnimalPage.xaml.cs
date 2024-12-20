using Microsoft.Maui.Controls;
namespace MvvmToolkitExmple.View
{
    public partial class AnimalPage : ContentPage
    {
        public AnimalPage()
        {
            InitializeComponent();
        }

        private async void OnCalculButtonClicked(object sender, EventArgs e)
        {
            // Adjust the navigation logic if needed
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
