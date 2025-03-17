using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAP_WebAPI.Models;

[Table("sales")]
public class Sale
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product product { get; set; }
    public int ProfileId { get; set; }
    public Profile profile { get; set; }
    public float Price { get; set; }
    public DateOnly SaleDate { get; set; }
}
