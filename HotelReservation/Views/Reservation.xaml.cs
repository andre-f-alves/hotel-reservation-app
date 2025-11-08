using HotelReservation.Models;

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

  private async void Button_Clicked1(object sender, EventArgs e)
  {
    try
    {
      ReservationModel reservation = new()
      {
        Room = (Room)room_picker.SelectedItem,
        Adults = Convert.ToInt32(stepper_adultos.Value),
        Children = Convert.ToInt32(stepper_criancas.Value),
        CheckIn = checkin_datepicker.Date,
        CheckOut = checkout_datepicker.Date
      };

      await Navigation.PushAsync(new ReservationView()
      {
        BindingContext = reservation
      });
    }
    catch (Exception ex)
    {
      await DisplayAlert("Erro", ex.Message, "OK");
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
