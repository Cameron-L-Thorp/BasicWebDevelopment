using BrianChallenge.Models;

namespace BrianChallenge.Data
{
    public class PersonRepository : IPersonService
    {
        private readonly ApplicationDbContext _context;
        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        //TODO need to add the code within these service methods and then rewrite the controller code to disconnect the controller form the DB
        public Task<int> AddOrUpdateAcync(Person state)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Person state)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
