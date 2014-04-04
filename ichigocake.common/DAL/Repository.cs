using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain;

namespace ichigocake.common.DAL
{
    public class Repository: IRepository
    {
        public IEnumerable<Cake> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Cake GetCakeById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cake cake)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cake cake)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
