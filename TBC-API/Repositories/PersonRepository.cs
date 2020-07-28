using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBC_API.Data;
using TBC_API.Models;

namespace TBC_API.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext dataContext;

        public PersonRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<PPerson> AddUser(PPerson pPerson)
        {
            await dataContext.PPerson.AddAsync(pPerson);
            await dataContext.SaveChangesAsync();

            return pPerson;
        }
    }
}
