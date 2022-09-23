using BrianChallenge.Models;

namespace BrianChallenge.Data
{
    public interface IPersonService
    {
        Task<IList<Person>> GetAllAsync();
        Task<int> AddOrUpdateAcync(Person state);
        Task<int> DeleteAsync(Person state);
        Task<int> DeleteAsync(int id);
        Task<int> ExistsAsync(int id);
    }
}
