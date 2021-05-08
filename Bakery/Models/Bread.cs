namespace Bakery.Models
{
  public class Bread
  {
    public int AmountOfBread { get; set; }
    public Bread(int amountOfBread)
    {
      AmountOfBread = amountOfBread;
    }
    public int BreadPrice()
    {
      if (AmountOfBread % 3 == 0)
      {
        int orderTotal = (AmountOfBread - (AmountOfBread / 3)) * 5;
        return orderTotal;
      }
      else
      {
        return AmountOfBread * 5;
      }
    }
  }
}