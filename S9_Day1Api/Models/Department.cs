﻿namespace S9_Day1Api.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Location { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        //
        //
        public int MyProperty { get; set; }

    }
}
