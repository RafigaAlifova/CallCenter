using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
  public   interface IRequestService
    {
        void Add(Request request);

        void Update(Request request);

        void Delete(Request request);

        List<Request> GetAll();  //m=> =m.Id==5

        Request Get(int id);

        int GetNextId();

        void DeleteAll();
    }
}
