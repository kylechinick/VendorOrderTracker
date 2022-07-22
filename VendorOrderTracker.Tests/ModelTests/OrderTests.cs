using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "title");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    [TestMethod]
      public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Bread Pallet";

      //Act
      Order newOrder = new Order(description);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }
  }
}