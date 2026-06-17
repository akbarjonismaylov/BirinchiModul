namespace Lesson11._1
{
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Position = "Software Developer",
                Salary = 60000
            };

            Employee employee2 = new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Jane",
                LastName = "Smith",
                Age = 28,
                Position = "Project Manager",
                Salary = 75000
            };

            AddEmployee(employee1);

            AddEmployee(employee2);
            DisplayEmployees();

            UpdateEmployee(employee2.EmployeeId, new Employee
            {
                FirstName = "John",
                LastName = "Smith",
                Age = 28,
                Position = "Senior Software Developer",
                Salary = 80000
            });

            DisplayEmployees();

            RemoveEmployee(employee1.EmployeeId);
            DisplayEmployees();
        }

        static void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        static void RemoveEmployee(Guid employeeId)
        {
            foreach (var employee in employees)
            {
                if (employee.EmployeeId == employeeId)
                {
                    employees.Remove(employee);
                    break;
                }
            }
        }

        static void UpdateEmployee(Guid employeeId, Employee newEmployee)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeId == employeeId)
                {
                    newEmployee.EmployeeId = employeeId;
                    employees[i] = newEmployee;
                    break;
                }
            }
        }

        static void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeId}");
                Console.WriteLine($"First Name: {employee.FirstName}");
                Console.WriteLine($"Last Name: {employee.LastName}");
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();

            }
        }
    }
}
