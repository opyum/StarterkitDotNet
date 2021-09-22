using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyanceApi.Services
{
    public interface ILoginService
    {
        UserDTO Authenticate(string userName, string ipAddress);
        string RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<UserDTO> GetAll();
        UserDTO GetById(int id);
        void Create(UserDTO user);
        void Update(UserDTO dto);
        void Delete(int idAppli);
        void GetAllWithRole(int idRole);
    }
}
