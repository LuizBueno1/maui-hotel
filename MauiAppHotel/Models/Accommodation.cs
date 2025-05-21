namespace MauiAppHotel.Models
{
    public class Accommodation
    {
        public Room SelectedRoom { get; set; }
        public int AdultCount { get; set; }
        public int ChildrenCount { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate {  get; set; }

        public int StayDuration
        {
            get => CheckOutDate.Subtract(CheckInDate).Days;
        }

        public double TotalValue
        {
            get
            {
                double adults_value = AdultCount * SelectedRoom.AdultDailyRate;
                double children_value = ChildrenCount * SelectedRoom.ChildDailyRate;

                double total = (adults_value + children_value) * StayDuration;

                return total;
            }
        }
    }
}
