using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//src: https://www.youtube.com/watch?v=BzzXbonNZJ4&list=PL6n9fhu94yhVowClAs8-6nYnfsOTma14P&index=8

namespace EmployeeManagementModels
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
    }
}
