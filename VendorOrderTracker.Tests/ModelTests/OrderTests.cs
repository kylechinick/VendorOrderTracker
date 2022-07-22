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
      string title = "Bread Pallet";
      string description = "A literal pallet stacked with bread";

      Order newOrder = new Order(description, title);
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
      public void GetDescription_ReturnsDescription_String()
    {
      string title = "Bread Pallet";
      string description = "A literal pallet stacked with bread";

      Order newOrder = new Order(description, title);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
      public void SetTitle_SetTitle_String()
    {
      string title = "Bread Pallet";
      string description = "A literal pallet stacked with bread";

      Order newOrder = new Order(description, title);

      string updatedTitle = "Bread Pallet 3000MaxExtreme";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
      public void SetDescription_SetDescription_String()
    {
      string title = "Bread Pallet";
      string description = "A literal pallet stacked with bread";

      Order newOrder = new Order(description, title);

      string updatedDescription = "A towering pallet stacked with bread";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }
  }
}