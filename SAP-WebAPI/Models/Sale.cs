using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SAP_WebAPI.Models;

[Table("sales")]
public class Sale
{
    public int Id { get; set; }
    public required Product product { get; set; }
    public required Profile profile { get; set; }
    [Precision(8, 2)]
    public decimal Price { get; set; }
    public DateOnly SaleDate { get; set; }
}
