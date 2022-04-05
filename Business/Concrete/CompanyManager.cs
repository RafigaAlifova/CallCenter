using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal compnyDal)
        {
            _companyDal = compnyDal;
        }

        public void Add(Company company)
        {
            this._companyDal.Add(company);
        }

        public void Delete(Company company)
        {
            this._companyDal.Delete(company);
        }

        public void DeleteAll()
        {
            this._companyDal.DeleteAll();
        }

        public Company Get(int id)
        {
            return this._companyDal.Get(m => m.Id == id);
        }

        public List<Company> GetAll()
        {
            return this._companyDal.GetAll();
        }

        public int GetNextId()
        {
            return this._companyDal.GetNextId();
        }

        public void Update(Company company)
        {
            this._companyDal.Update(company);
        }

        public List<Company> Search(string name, int strParam)
        {
            var result = new List<Company>();

            switch (strParam)
            {
                case -1:
                case 0:
                    result = this. _companyDal.GetAll(m => m.Name.Contains(name));
                    break;
                case 1:
                    result = this._companyDal.GetAll(m => m.Name.StartsWith(name));
                    break;
                case 2:
                    result = this._companyDal.GetAll(m => m.Name.EndsWith(name));
                    break;
            }



            return result;
        }

    }
}
