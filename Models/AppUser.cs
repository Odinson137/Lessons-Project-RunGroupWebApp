
using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Mieleage { get; set; }
        public Address? Address { get; set; }

        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Race { get; set; }
    }
}
