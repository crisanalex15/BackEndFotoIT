using System.ComponentModel.DataAnnotations;

namespace ItFoto.Models
{
    public class emailSent
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Description { get; set; }
    }
}
