using Microsoft.AspNetCore.Components;
using EmployeeManagementModels;

namespace BlazorTestApp.Client.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> EmployeesList { get; set; }

        protected override Task OnInitializedAsync()
        {
            EmployeesList = LoadEmployees();
            return base.OnInitializedAsync();
        }

        //Hard coding the employee list (for now)
        private IEnumerable<Employee> LoadEmployees()
        {
            IEnumerable<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Walter",
                    LastName = "White",
                    Email = "walterwhite@bb.com",
                    BirthDate = new DateTime(1990, 9, 23),
                    Gender = Gender.Male,
                    Department = new Department
                    {
                        DepartmentID = 1,
                        DepartmentName = "Department One",
                    }
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Jesse",
                    LastName = "Pinkman",
                    Email = "jessepinkman@bb.com",
                    BirthDate = new DateTime(1970, 12, 19),
                    Gender = Gender.Male,
                    Department = new Department
                    {
                        DepartmentID = 2,
                        DepartmentName = "Department Two",
                    }
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Skyler",
                    LastName = "White",
                    Email = "skylerwhite@bb.com",
                    BirthDate = new DateTime(1985, 3, 1),
                    Gender = Gender.Female,
                    Department = new Department
                    {
                        DepartmentID = 1,
                        DepartmentName = "Department One",
                    }
                },
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Marie",
                    LastName = "Schrader",
                    Email = "marieschrader@bb.com",
                    BirthDate = new DateTime(1985, 3, 1),
                    Gender = Gender.Female,
                    Department = new Department
                    {
                        DepartmentID = 2,
                        DepartmentName = "Department Two",
                    }
                },
                new Employee
                {
                    EmployeeId = 5,
                    FirstName = "Gus",
                    LastName = "Fring",
                    Email = "gusfring@bb.com",
                    BirthDate = new DateTime(1957, 1, 10),
                    Gender = Gender.Other,
                    Department = new Department
                    {
                        DepartmentID = 3,
                        DepartmentName = "Department Three",
                    }
                }
            };

            return employees;
        }
    }
}
