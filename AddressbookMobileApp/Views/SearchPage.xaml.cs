using AddressbookMobileApp.ViewModels;

namespace AddressbookMobileApp.Views;

public partial class SearchPage : ContentPage
{
	public SearchPage(SearchVievModel vievModel)
	{
		InitializeComponent();

		BindingContext=vievModel;
	}
}