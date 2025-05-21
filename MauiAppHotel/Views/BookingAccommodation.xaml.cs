using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class BookingAccommodation : ContentPage
{
	App AppProperties;
	public BookingAccommodation()
	{
		InitializeComponent();

		AppProperties = (App)Application.Current;

		pck_room.ItemsSource = AppProperties.rooms_list;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Accommodation a = new Accommodation
			{
				SelectedRoom = (Room)pck_room.SelectedItem,
				AdultCount = Convert.ToInt32(stp_adults.Value),
				ChildrenCount = Convert.ToInt32(stp_kids.Value),
				CheckInDate = dtpck_checkin.Date,
				CheckOutDate = dtpck_checkout.Date
			};



			await Navigation.PushAsync(new ConfirmedAccommodation()
			{
				BindingContext = a
			});

		}
		catch (Exception ex)
		{
			await DisplayAlert("Oops", ex.Message, "OK");
		}
	}

	private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
	{
		DatePicker element = sender as DatePicker;

		DateTime checkin_selected_date = element.Date;

		dtpck_checkout.MinimumDate = checkin_selected_date.AddDays(1);
		dtpck_checkout.MaximumDate = checkin_selected_date.AddMonths(6);
	}

    private void Btn_About_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new AboutPage());
		} 
		catch(Exception ex)
		{
			DisplayAlert("Oops", ex.Message, "OK");
		}
    }

}