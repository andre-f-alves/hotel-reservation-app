using HotelReservation.Models;

namespace HotelReservation;

public partial class App : Application
{
  public List<Room> rooms_list =
  [
    new()
    {
      Description = "Suíte Super Luxo",
      AdultDailyPrice = 110.0,
      ChildDailyPrice = 55.0
    },
    new()
    {
      Description = "Suíte Luxo",
      AdultDailyPrice = 80.0,
      ChildDailyPrice = 40.0
    },
    new()
    {
      Description = "Suíte Single",
      AdultDailyPrice = 50.0,
      ChildDailyPrice = 25.0
    },
    new()
    {
      Description = "Suíte Econômica",
      AdultDailyPrice = 30.0,
      ChildDailyPrice = 15.0
    }
  ];
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new NavigationPage(new Views.Reservation()))
    {
      Width = 400,
      Height = 700
    };
	}
}
