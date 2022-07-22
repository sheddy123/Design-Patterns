namespace Creational_Patterns.Models
{
    public class Employee_Type
    {
        public int Id { get; set; }
        public string EmoloyeeType { get; set; }
        public Employee EmployeeId { get; set; }
        public EmployeeType employeeType { get; set; }
        public enum EmployeeType
        {
            Permanent = 0,
            Contract = 1
        }
    }
    
}
