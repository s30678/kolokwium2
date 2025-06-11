using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Title")]
public class Title
{
    [Key]
    public int TitleId { get; set; }
    [Required]
    [MaxLength(120)]
    public string Name { get; set; }
}