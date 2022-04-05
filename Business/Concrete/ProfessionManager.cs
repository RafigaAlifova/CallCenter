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
     

        public List<Profession> Search(string name, int strParam)
        {
            var result = new List<Profession>();

            switch (strParam)
            {
                case -1:
                case 0:
                    result = this._professionDal.GetAll(m => m.Name.Contains(name));
                    break;
                case 1:
                    result = this._professionDal.GetAll(m => m.Name.StartsWith(name));
                    break;
                case 2:
                    result = this._professionDal.GetAll(m => m.Name.EndsWith(name)  );
                    break;
            }



            return result;
        }
    }
}