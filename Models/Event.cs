using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Event
{
    [Key]
    public int EventId { get; set; }
    public int UserId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    public TimeSpan Time { get; set; }

    [Required]
    public int Duration { get; set; }

    [Required]
    public string HourOrMin { get; set; }

    [Required]
    public DateTime Date { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //One to Many
    public User Creator { get; set; }

    //Many to Many
    public List<Joinz> EventList { get; set; }

}
