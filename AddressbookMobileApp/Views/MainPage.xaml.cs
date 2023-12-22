using AddressbookMobileApp.ViewModels;

namespace AddressbookMobileApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void Btn_ShowList_Clicked(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Clicked(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Clicked(object sender, EventArgs e)
        {

        }

        private void Btn_Remove_Clicked(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Clicked(object sender, EventArgs e)
        {

        }

        private void Btn_Quit_Clicked(object sender, EventArgs e)
        {

        }
    }

}
