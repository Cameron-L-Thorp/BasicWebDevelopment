using System.ComponentModel.DataAnnotations;

namespace BrianChallenge.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 747)]
        public string Name { get; set; }


    }
}
