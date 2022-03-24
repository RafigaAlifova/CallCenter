using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
   public  interface IEmployeeService
    {
        void Add(Employee employee);

        void Update(Employee employee);

        void Delete(Employee employee);

        List<Employee> GetAll();  //m=> =m.Id==5

        Employee Get(int id);

        int GetNextId();

        void DeleteAll();
    }
}
