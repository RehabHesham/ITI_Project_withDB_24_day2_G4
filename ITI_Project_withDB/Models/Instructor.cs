namespace ITI_Project_withDB.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Salary { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }


        // Navigation Property
        public List<Course>? Courses { get; set; }

        public override string ToString()
        {
            return $"name: {Name}, salary: {Salary}";
        }
    }
}
