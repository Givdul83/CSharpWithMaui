namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void Add_Btn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//AddPage");
        }

        private async void Search_Btn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SearchPage");
        }

        private async void ShowList_Btn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ShowListPage");
        }

        private async void Remove_Btn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//RemovePage");
        }

        private async void Update_Btn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//UpdatePage");
        }

        private async void Quit_Btn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//QuitPage");
        }
    }

}
