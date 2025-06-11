using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Character_title")]
public class Character_title
{
    [ForeignKey(nameof(Character))]
    public int CharacterId { get; set; }
    [ForeignKey(nameof(Title))]
    public int TitleId { get; set; }
    [Required]
    public DateTime AcquiredAt { get; set; }
    public Character Character { get; set; }
    public Title Title { get; set; }
    
    
    
}