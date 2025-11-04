namespace HotelReservation.Views;

public partial class Reservation : ContentPage
{
  App appProperties;
	public Reservation()
	{
    InitializeComponent();

    appProperties = (App)Application.Current;

    room_picker.ItemsSource = appProperties.rooms_list;

    checkin_datepicker.MinimumDate = DateTime.Now;
    checkin_datepicker.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

    checkout_datepicker.MinimumDate = checkin_datepicker.Date.AddDays(1);
    checkout_datepicker.MaximumDate = checkin_datepicker.Date.AddMonths(6);
	}

  private void Button_Clicked(object sender, EventArgs e)
  {
    Navigation.PushAsync(new About());
  }

  private void Button_Clicked1(object sender, EventArgs e)
  {
    try
    {
      Navigation.PushAsync(new ReservationView());
    }
    catch (Exception ex)
    {
      DisplayAlert("Erro", ex.Message, "OK");
    }
  }

  private void checkin_datepicker_DateSelected(object sender, DateChangedEventArgs e)
  {
    DatePicker datePicker = sender as DatePicker;
    DateTime selectedDate = datePicker.Date;

    checkout_datepicker.MinimumDate = selectedDate.AddDays(1);
    checkout_datepicker.MaximumDate = selectedDate.AddMonths(6);
  }
}
