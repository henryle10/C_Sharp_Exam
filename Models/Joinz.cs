using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Joinz
{
    [Key]
    public int JoinzId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //Foreign Keys
    public int UserId { get; set; }
    public int EventId { get; set; }

    //Navigation Properties
    public User Attendee { get; set; }
    public Event Event { get; set; }
    public Joinz() { }
    public Joinz(int uid, int eventId)
    {
        UserId = uid;
        EventId = eventId;
    }
}
