using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Repositories.Base;

namespace ichigocake.domain.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private DbContext context;
        private Repository<Cake> _cakeRepository;
        private Repository<Category> _categoryRepository;
        private Repository<Reference> _referenceRepository;

        public Repository<Cake> CakeRepository
        {
            get
            {
                if (this._cakeRepository == null)
                {
                    this._cakeRepository = new Repository<Cake>(context);
                }
                return _cakeRepository;
            }
        }

        public Repository<Category> CategoryRepository
        {
            get
            {
                if (this._categoryRepository == null)
                {
                    this._categoryRepository = new Repository<Category>(context);
                }
                return _categoryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool _disposed = false;

        public UnitOfWork(Repository<Cake> cakeRepository)
        {
            this._cakeRepository = cakeRepository;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
