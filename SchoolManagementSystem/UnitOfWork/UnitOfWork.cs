using System;
using SchoolManagementSystem.BaseRepository;

namespace SchoolManagementSystem.UnitOfWork
{
    public class UnitofWork : IDisposable
    {
        private SchoolDBContext context = new SchoolDBContext();
        private BaseRepository<User> userRepository;
        public BaseRepository<User> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                    this.userRepository = new BaseRepository<User>(context);
                return userRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}