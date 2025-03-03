using System;
using ShopStore.Models;

namespace ShopStore.Clients;

public class ShopClients
{
    private List<ShopDetails> shops = [
  new() {
      Id = 1,
      Name = "Bread",
      Category = "Bakery",
      Price = 80,
      Date = new DateOnly(2025,01,26)
      },
  new() {
      Id = 2,
      Name = "Milk",
      Category = "Dairy",
      Price = 50,
      Date = new DateOnly(2025,01,26)
      }
  ];

  public ShopDetails[] GetShop() => [.. shops];
}
