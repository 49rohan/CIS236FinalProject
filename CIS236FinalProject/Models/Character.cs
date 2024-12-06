using System.ComponentModel.DataAnnotations;

namespace CIS236FinalProject.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Range(1, 999)]
        public int Attack {  get; set; }
        [Range(1, 999)]
        public int Defense { get; set; }
        [Range(1, 999)]
        public int Speed { get; set; }

        public List<Move> Moves { get; set; } = new List<Move>();

        [Required]
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
