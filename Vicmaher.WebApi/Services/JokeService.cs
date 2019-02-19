using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Platform.DAL.Paging;
using Platform.DAL.Query;
using Platform.DAL.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vicmaher.WebApi.Services.Interfaces;
using Vicmaher.WebServices.Entities;

namespace Vicmaher.WebApi.Services
{
    public class JokeService : IJokeService
    {
        private readonly IUnitOfWorkProvider _unitOfWorkProvider;
        private readonly IDataPager<Joke> _pager;

        public JokeService(
            IUnitOfWorkProvider unitOfWorkProvider,
            IDataPager<Joke> pager)
        {
            _unitOfWorkProvider = unitOfWorkProvider ?? throw new ArgumentNullException(nameof(unitOfWorkProvider));
            _pager = pager ?? throw new ArgumentNullException(nameof(pager));
        }

        public async Task<IEnumerable<Joke>> GetAllJokesAsync()
        {
            using (var uow = _unitOfWorkProvider.CreateUnitOfWork())
            {
                var repository = uow.GetRepository<Joke>();
                return await repository.GetAllAsync(null);
            }
        }

        public async Task<DataPage<Joke>> GetAllJokesAsync(int pageNumber, int pageLength)
        {
            var jokes = await _pager.GetAsync(pageNumber, pageLength);
            return jokes;
        }

        public async Task<IEnumerable<Joke>> GetAllJokesByCategoryIdAsync(int categoryId)
        {
            using (var uow = _unitOfWorkProvider.CreateUnitOfWork())
            {
                Filter<Joke> filter = new Filter<Joke>(null);
                filter.AddExpression(c => c.Category.Id == categoryId);

                var repository = uow.GetRepository<Joke>();

                Func<IQueryable<Joke>, IQueryable<Joke>> func = query =>
                {
                    return query.Include(c => c.Category);
                };

                return (await repository.QueryAsync(filter.Expression, includes: func)).ToList();
            }
        }
    }
}
