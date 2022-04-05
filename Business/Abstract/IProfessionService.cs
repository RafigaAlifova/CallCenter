using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IProfessionService
    {
        void Add(Profession profession);

        void Update(Profession profession);

        void Delete(Profession profession);

        List<Profession> GetAll();  //m=> =m.Id==5

        Profession Get(int id);

        int GetNextId();
        List<Profession> Search(string name ,int strParam);


        void DeleteAll();
    }
}
