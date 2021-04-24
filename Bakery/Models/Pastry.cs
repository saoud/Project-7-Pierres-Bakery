namespace Bakery.Models
{
  public class Pastries
  {
    public int AmountOfPastries { get; set; }
    public Pastries(int amountOfPastries)
    {
      AmountOfPastries = amountOfPastries;
    }
  }
}