using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAP_WebAPI.Models;

[Table("profiles")]
public class Profile
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Ballance { get; set; } = 0.0f;
    public int UserId { get; set; }
    public User user { get; set; }
}
