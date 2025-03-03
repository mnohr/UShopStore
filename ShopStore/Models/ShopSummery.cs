using System;

namespace ShopStore.Models;

public class ShopSummery
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Category { get; set; }

    public decimal Price { get; set; }

    public DateOnly Date { get; set; } 
}
