using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBC_API.Models;

namespace TBC_API.Repositories
{
    public interface IPersonRepository
    {
        Task<PPerson> AddUser(PPerson pPerson);
    }
}
