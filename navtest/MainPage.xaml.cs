namespace navtest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        public async void OnClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Page2");
        }
    }
}