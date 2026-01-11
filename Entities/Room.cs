using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Data.Entities;

public class Room
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;

    [Range(1, 1000)]
    public int Capacity { get; set; }
}
