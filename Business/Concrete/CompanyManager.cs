using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _compnyDal;

        public CompanyManager(ICompanyDal compnyDal)
        {
            _compnyDal = compnyDal;
        }

        public void Add(Company company)
        {
            this._compnyDal.Add(company);
        }

        public void Delete(Company company)
        {
            this._compnyDal.Delete(company);
        }

        public void DeleteAll()
        {
            this._compnyDal.DeleteAll();
        }

        public Company Get(int id)
        {
            return this._compnyDal.Get(m => m.Id == id);
        }

        public List<Company> GetAll()
        {
            return this._compnyDal.GetAll();
        }

        public int GetNextId()
        {
            return this._compnyDal.GetNextId();
        }

        public void Update(Company company)
        {
            this._compnyDal.Update(company);
        }
    }
}
