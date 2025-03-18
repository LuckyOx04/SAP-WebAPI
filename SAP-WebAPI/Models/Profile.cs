using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SAP_WebAPI.Models;

[Table("profiles")]
public class Profile
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    [Precision(14, 2)]
    public decimal Ballance { get; set; } = 0.0m;
    public required User user { get; set; }
}
