using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAP_WebAPI.Models;

[Table("campaigns")]
public class Campaign
{
    public long Id { get; set; }
    public string Name { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public bool IsActive { get; set; }
}
