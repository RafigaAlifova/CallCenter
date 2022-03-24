using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace MusicLibrary.Business.Concrete
{
    public class ProfessionManager : IProfessionService
    {
        private readonly IProfessionDal _professionDal;

        public ProfessionManager(IProfessionDal professionDal)
        {
            _professionDal = professionDal;
        }

        public void Add(Profession profession)
        {
            this._professionDal.Add(profession);
        }

        public void Delete(Profession profession)
        {
            this._professionDal.Delete(profession);
        }

        public void DeleteAll()
        {

            this._professionDal.DeleteAll();
        }

        public Profession Get(int id)
        {
            return this._professionDal.Get(m => m.Id == id);
        }

        public List<Profession> GetAll()
        {
            return this._professionDal.GetAll();
        }

        public int GetNextId()
        {

            return this._professionDal.GetNextId();
        }

        public void Update(Profession profession)
        {
            this._professionDal.Update(profession);
        }
    }
}