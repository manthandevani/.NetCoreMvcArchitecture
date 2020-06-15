using DemoArch.Common.ViewModels;
using DemoArch.Repository.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoArch.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;

        public UserService(IUnitOfWork unit)
        {
            _uow = unit;
        }

        public IEnumerable<UserViewModel> GetUserList()
        {
            var allUsers = _uow.UserRepository.GetAll();
            if (allUsers != null)
            {
                return allUsers.Select(a => new UserViewModel
                {
                    FirstName = a.FirstName,
                    LastName = a.LastName
                }).ToList();
            }
            return new List<UserViewModel>();

        }

        public UserViewModel GetUser(int Id)
        {
            var user = _uow.UserRepository.GetById(Id);
            if (user != null)
            {
                return new UserViewModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName
                };
            }
            return new UserViewModel();
        }
    }
}
