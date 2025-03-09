namespace S9_Day1Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public Department? Department { get; set; }
    }
}
