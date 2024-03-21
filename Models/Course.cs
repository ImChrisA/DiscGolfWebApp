namespace DiscGolfWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Region { get; set; }
        public required string City { get; set; }
        public required string Difficulty { get; set; }
        public int Holes { get; set;}
        public int Par { get; set;}
        public int length { get; set; }
        public required string Description { get; set; }

        public Course()
        {
            
        }

    }
}
