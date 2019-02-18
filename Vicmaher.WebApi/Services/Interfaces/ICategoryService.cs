using System.Collections.Generic;
using System.Threading.Tasks;
using Vicmaher.WebServices.Entities;

namespace Vicmaher.WebApi.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
