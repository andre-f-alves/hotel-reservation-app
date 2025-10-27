namespace HotelReservation.Views;

public partial class Reservation : ContentPage
{
	public Reservation()
	{
		InitializeComponent();
	}

  private void Button_Clicked(object sender, EventArgs e)
  {
    App.Current.MainPage = new NavigationPage(new About());
  }
}
