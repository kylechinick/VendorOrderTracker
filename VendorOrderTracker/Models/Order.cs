using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description, string title)
    {
      Title = title;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
