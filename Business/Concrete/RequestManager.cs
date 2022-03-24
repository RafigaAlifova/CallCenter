using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RequestManager : IRequestService
    {
        private readonly IRequestDal _requestDal;

        public RequestManager(IRequestDal requestDal)
        {
            _requestDal = requestDal;
        }

        public void Add(Request request)
        {
            this._requestDal.Add(request);
        }

        public void Delete(Request request)
        {
            this._requestDal.Delete(request);
        }

        public void DeleteAll()
        {
            this._requestDal.DeleteAll();
        }

        public Request Get(int id)
        {
            return this._requestDal.Get(m => m.Id == id);
        }

        public List<Request> GetAll()
        {
            return this._requestDal.GetAll();
        }

        public int GetNextId()
        {
            return this._requestDal.GetNextId();
        }

        public void Update(Request request)
        {
            this._requestDal.Update(request);
        }
    }
}
