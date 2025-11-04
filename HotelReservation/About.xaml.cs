namespace HotelReservation;

public partial class About : ContentPage
{
  public About()
  {
    InitializeComponent();
  }
  
  private void Button_Clicked(object sender, EventArgs e)
  {
    Navigation.PopAsync();
  }
}
