using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        ApplicationdbContext db;
        public EmployeeRepository(ApplicationdbContext db) // DI pattern inject dependency in constructor.
        {
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var result = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Employees.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public Employee GetEmployeeById(int id)
        {
            var result = db.Employees.Where(x => x.Id == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }

        public int UpdateEmployee(Employee employee)
        {
            int res = 0;


            var result = db.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = employee.Name; // book contains new data, result contains old data
                result.Age = employee.Age;
                result.Salary = employee.Salary;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
