using System;
namespace DependencyInjection.Models
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher()
        {
            FirstName = "Ali";
            LastName = "Yılmaz";
        }
        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
