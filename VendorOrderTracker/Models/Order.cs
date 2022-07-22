using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string VendorName { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description, string vendorName)
    {
      VendorName = vendorName;
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
