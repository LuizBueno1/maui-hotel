
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Room> rooms_list = new List<Room>
        {
            new Room()
            {
                Description = "Super Luxury Suite",
                AdultDailyRate = 110.0,
                ChildDailyRate = 55.0
            },
            new Room()
            {
                Description = "Luxury Suite",
                AdultDailyRate = 80.0,
                ChildDailyRate = 40.0
            },
            new Room()
            {
                Description = "Single Suite",
                AdultDailyRate = 50.0,
                ChildDailyRate = 25.0
            },
            new Room()
            {
                Description = "Slump Suite",
                AdultDailyRate = 25.0,
                ChildDailyRate = 12.5
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.BookingAccommodation());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;

            return window;

        }
    }
}
