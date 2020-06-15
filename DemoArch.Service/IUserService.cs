using DemoArch.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoArch.Service
{
    public interface IUserService
    {
        IEnumerable<UserViewModel> GetUserList();

        UserViewModel GetUser(int Id);
    }
}
