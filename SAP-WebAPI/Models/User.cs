using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SAP_WebAPI.Models;

[Table("users")]
[Index(nameof(Username), IsUnique = true)]
public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public List<Role>? Roles { get; set; }

    //TODO Add setting in db set for many to many recognition
}
