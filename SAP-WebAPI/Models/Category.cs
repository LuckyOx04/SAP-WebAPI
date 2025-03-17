using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAP_WebAPI.Models;

[Table("categories")]
public class Category
{
    public long Id { get; set; }
    public string Name { get; set; }
}
