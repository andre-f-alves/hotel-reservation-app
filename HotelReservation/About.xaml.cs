namespace HotelReservation;

public partial class About : ContentPage
{
  public About()
  {
    InitializeComponent();
  }
  
  private void Button_Clicked(object sender, EventArgs e)
  {
    App.Current.MainPage = new NavigationPage(new Views.Reservation());
  }
}
