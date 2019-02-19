using Platform.DAL.Paging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vicmaher.WebServices.Entities;

namespace Vicmaher.WebApi.Services.Interfaces
{
    public interface IJokeService
    {
        Task<IEnumerable<Joke>> GetAllJokesAsync();

        Task<DataPage<Joke>> GetAllJokesAsync(int pageNumber, int pageLength);

        Task<IEnumerable<Joke>> GetAllJokesByCategoryIdAsync(int categoryId);
    }
}
