using Entities.Concrete;
using System.Collections.Generic;
namespace Business.Abstract
{
   public  interface ICompanyService
    {
        void Add(Company company);

        void Update(Company company);

        void Delete(Company company);

        List<Company> GetAll();  //m=> =m.Id==5

        Company Get(int id);

        int GetNextId();

        void DeleteAll();
    }
}
