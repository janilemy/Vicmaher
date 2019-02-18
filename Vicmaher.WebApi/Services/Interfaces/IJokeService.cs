using System.Collections.Generic;
using System.Threading.Tasks;
using Vicmaher.WebServices.Entities;

namespace Vicmaher.WebApi.Services.Interfaces
{
    public interface IJokeService
    {
        Task<IEnumerable<Joke>> GetAllJokesAsync();

        Task<IEnumerable<Joke>> GetAllJokesByCategoryIdAsync(int categoryId);
    }
}
