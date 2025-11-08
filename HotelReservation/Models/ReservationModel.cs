namespace HotelReservation.Models;

public class ReservationModel
{
  public Room Room { get; set; }
  public int Adults { get; set; }
  public int Children { get; set; }
  public DateTime CheckIn { get; set; }
  public DateTime CheckOut { get; set; }
  public int Stay
  {
    get => CheckOut.Subtract(CheckIn).Days;
  }
  public double TotalPrice
  {
    get
    {
      double adultsPrice = Adults * Room.AdultDailyPrice;
      double childrenPrice = Children * Room.ChildDailyPrice;
      double total = (adultsPrice + childrenPrice) * Stay;
      return total;
    }
  }
}
