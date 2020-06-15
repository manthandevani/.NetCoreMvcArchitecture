using DemoArch.Repository.Entities;

namespace DemoArch.Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private DemoContext _context;

        public UserRepository(DemoContext context) : base (context)
        {
            _context = context;
        }
    }
}
