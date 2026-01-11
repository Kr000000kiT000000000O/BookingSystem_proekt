using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Data.Entities;

public class Booking
{
    public int Id { get; set; }

    [Required]
    public int RoomId { get; set; }

    public Room Room { get; set; } = null!;

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }
}
