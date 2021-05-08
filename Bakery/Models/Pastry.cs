namespace Bakery.Models
{
  public class Pastry
  {
    private int _cost = 0;
    public int Cost 
    {
      get
      {
        return _cost;
      }
    }
    public int OrderAmount { get; } 

    public Pastry(int amount)
    {
      OrderAmount = amount;
    }
    public void CalculatePastryCost()
    {
      _cost += ((OrderAmount/3) * 5);
      _cost +=((OrderAmount % 3) * 2);
    }
  }
}