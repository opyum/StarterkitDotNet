using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterKitAPI.Services
{
    public interface IPersonneService
    {

        IEnumerable<PersonneDTO> GetAll();
        PersonneDTO GetById(int id);
        void Create(PersonneDTO user);
        void Update(PersonneDTO dto);
        void Delete(int idAppli);
    }
}
