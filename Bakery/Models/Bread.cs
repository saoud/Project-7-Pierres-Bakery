namespace Bakery.Models
{
  public class Bread
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

    public Bread(int amount)
    {
      OrderAmount = amount;
    }
    public void CalculateBreadCost()
    {
      _cost += ((OrderAmount/3)* 10);
      _cost += ((OrderAmount % 3) * 5);
    }
  }
}