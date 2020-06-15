using DemoArch.Repository.Entities;
using DemoArch.Repository.Repository;
using System;

namespace DemoArch.Repository.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private DemoContext _context;

        public UnitOfWork(DemoContext context)
        {
            _context = context;
        }

        //Delete this default constructor if using an IoC container
        public UnitOfWork()
        {
            _context = new DemoContext();
        }

        public IUserRepository UserRepository
        {
            get { return new UserRepository(_context); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
