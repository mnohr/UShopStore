using System;
using ShopStore.Models;

namespace ShopStore.Clients;

public class CategoryClients
{
  private readonly ShopCategory[] shopCategories = [
    new(){
        Id = 1,
        Name = "Electronics",
    },
    new(){
        Id = 2,
        Name = "Fashion",
    },
    new(){
        Id = 3,
        Name = "Home and Kitchen",
    },
    new(){
        Id = 4,
        Name = "Sports",
    },
    new(){
        Id = 5,
        Name = "Toys",
    },
    new(){
        Id = 6,
        Name = "Books",
    }
  ];

  public ShopCategory[] GetShopCategories => shopCategories;
}
