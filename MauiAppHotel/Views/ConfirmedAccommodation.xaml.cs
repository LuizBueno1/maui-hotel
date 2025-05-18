namespace MauiAppHotel.Views;

public partial class ConfirmedAccommodation : ContentPage
{
	public ConfirmedAccommodation()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			DisplayAlert("Oops", ex.Message, "OK");
		}
    }
}