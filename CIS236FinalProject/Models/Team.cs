using System.ComponentModel.DataAnnotations;

namespace CIS236FinalProject.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 4)]
        public int MaxCharacters { get; set; } = 4;

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();

    }
}
