using Voyance.Models;
using System.Collections.Generic;

namespace Voyance.Business
{
    public interface IUserBusiness
    {
        void GetAllUsersWithRole(int idRole);
    }
}