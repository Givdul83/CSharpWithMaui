using AddressbookMobileApp.ViewModels;

namespace AddressbookMobileApp.Views;

public partial class RemovePage : ContentPage
{
	public RemovePage(RemoveViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}