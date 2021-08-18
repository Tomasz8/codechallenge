using System;

namespace Code_Challenge.Models
{
    public class Driver : BaseModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public DateTime BirthDate { get; set; }

        public int Age => DateTime.Today.Year - BirthDate.Year; //simplified
    }
}
