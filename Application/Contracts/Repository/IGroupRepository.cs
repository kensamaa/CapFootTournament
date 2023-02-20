using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface IGroupRepository : IGenericRepository<Groupe>
    {
        //Task<List<Groupe>> GetAll();
        //Task<List<Groupe>> FindAll();
        Task<bool> IsGroupUnique(string name);
        Task<List<Team>> getListTeam(Guid groudId);
    }
}
