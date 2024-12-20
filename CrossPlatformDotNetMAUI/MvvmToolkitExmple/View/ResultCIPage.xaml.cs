namespace MvvmToolkitExmple.View
{
    public partial class ResultCIPage : ContentPage
    {
        public ResultCIPage()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(".."); // Navigates back to the previous page
        }
    }
}
