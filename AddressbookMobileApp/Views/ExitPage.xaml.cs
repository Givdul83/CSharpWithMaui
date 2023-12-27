using AddressbookMobileApp.ViewModels;

namespace AddressbookMobileApp.Views;

public partial class ExitPage : ContentPage
{
	public ExitPage(ExitViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}