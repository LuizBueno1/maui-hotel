namespace MauiAppHotel.Views;

public partial class BookingAccommodation : ContentPage
{
	public BookingAccommodation()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new ConfirmedAccommodation());
		}
		catch (Exception ex)
		{
			DisplayAlert("Oops", ex.Message, "OK");
		}
	}
}