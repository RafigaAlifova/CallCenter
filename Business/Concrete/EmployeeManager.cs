using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
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
        public List<Employee> Search(string firstName, string lastName, int professionId, int companyId, bool status, int strParam)
        {
            var result = new List<Employee>();
         
                    switch (strParam)
                    {
                        case -1:
                        case 0:
                            result = this._employeeDal.GetAll(m => m.FirstName.Contains(firstName) &
                                                                   m.LastName.Contains(lastName) &
                                                                   m.ProfessionId == professionId &
                                                                   m.CompanyId==companyId&
                                                                   m.IsFree==status);
                            break;
                        case 1:
                            result = this._employeeDal.GetAll(m => m.FirstName.StartsWith(firstName) &
                                                                   m.LastName.StartsWith(lastName) &
                                                                   m.ProfessionId == professionId &
                                                                   m.CompanyId == companyId &
                                                                   m.IsFree == status);
                    break;
                        case 2:
                            result = this._employeeDal.GetAll(m => m.FirstName.EndsWith(firstName) &
                                                                   m.LastName.EndsWith(lastName) &
                                                                   m.ProfessionId == professionId &
                                                                   m.CompanyId == companyId &
                                                                   m.IsFree == status);
                    break;
                    }
                    
            

            return result;
        }

        public List<Employee> GetByProfessionId(int professionId)
        {
            return this._employeeDal.GetAll(m => m.ProfessionId == professionId);

        }

        public List<Employee> GetByCompanyId(int companyId)
        {
            return this._employeeDal.GetAll(m => m.CompanyId == companyId);
        }
    }
}
