using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            this._employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            this._employeeDal.Delete(employee);
        }

        public void DeleteAll()
        {
            this._employeeDal.DeleteAll();
        }

        public Employee Get(int id)
        {
            return this._employeeDal.Get(m => m.Id == id);
        }

        public List<Employee> GetAll()
        {
            return this._employeeDal.GetAll();
        }

        public int GetNextId()
        {
            return this._employeeDal.GetNextId();
        }

        public void Update(Employee employee)
        {
            this._employeeDal.Update(employee);
        }
    }
}
