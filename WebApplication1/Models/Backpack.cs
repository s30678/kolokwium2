using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Backpack")]
public class Backpack
{
    [ForeignKey(nameof(Character))]
    public int CharacterId { get; set; }
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    [Required]
    public int Amount { get; set; }
    public Character Character { get; set; }
    public Item Item { get; set; }
}