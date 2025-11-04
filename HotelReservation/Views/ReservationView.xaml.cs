namespace HotelReservation.Views;

public partial class ReservationView : ContentPage
{
	public ReservationView()
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
      DisplayAlert("Erro", ex.Message, "OK");
    }
  }
}
