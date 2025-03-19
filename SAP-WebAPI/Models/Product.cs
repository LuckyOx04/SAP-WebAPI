using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAP_WebAPI.Models;

[Table("products")]
public class Product
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required string Brand { get; set; }
    public required Category Category { get; set; }
    public string? Description { get; set; }
    public float Price { get; set; }
    public float MinPrice { get; set; }
    public int Discount { get; set; }
    public int CampaignDiscount { get; set; }
    public string? ImageLink { get; set; }
    public int Availability { get; set; }
    public Campaign? Campaign { get; set; }
}
