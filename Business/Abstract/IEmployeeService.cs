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
        List<Employee> Search(string firstName, string lastName, int professionId, int companyId, bool status, int strParam);
        Employee Get(int id);
        int GetNextId();
        void DeleteAll();
        List<Employee> GetByProfessionId(int professionId);
        List<Employee> GetByCompanyId(int companyId);

    }
}
