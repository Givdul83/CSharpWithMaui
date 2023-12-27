using AddressbookMobileApp.ViewModels;

namespace AddressbookMobileApp.Views;

public partial class AddPage : ContentPage
{
	public AddPage(AddVievModel vievModel)
	{
		InitializeComponent();
		BindingContext = vievModel;
	}
}