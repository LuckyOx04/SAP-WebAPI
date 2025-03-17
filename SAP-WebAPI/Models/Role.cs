using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace SAP_WebAPI.Models;

[Table("roles")]
[Index(nameof(Name), IsUnique = true)]
public class Role
{
    public int Id { get; set; }

    public string Name { get; set; }
}
