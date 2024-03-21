using System.ComponentModel.DataAnnotations;

namespace DiscGolfWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Region { get; set; }
        public required string City { get; set; }
        public required string Difficulty { get; set; }
        [Range(1, 18)]
        public int Holes { get; set;}
        [Range(1, 200)]
        public int Par { get; set;}
        [Range(1, 20000)]
        public int length { get; set; }
        public required string Description { get; set; }

        public Course()
        {
            
        }

    }
}
