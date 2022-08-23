using System.ComponentModel.DataAnnotations;

namespace ERIL.Models
{
    public class Papers
    {
        [Key]
        public int Number { get; set; }
        [Required]
        public string Title { get; set; }

        public string Course { get; set; }

        public DateTime DateUploaded { get; set; } = DateTime.Now;
    }
}
