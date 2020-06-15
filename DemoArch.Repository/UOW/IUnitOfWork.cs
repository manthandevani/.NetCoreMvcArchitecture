using DemoArch.Repository.Repository;
using System;

namespace DemoArch.Repository.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
    }
}
