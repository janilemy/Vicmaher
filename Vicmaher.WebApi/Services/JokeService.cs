using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<JokeService> _logger;

        public JokeService(
            IUnitOfWorkProvider unitOfWorkProvider,
            ILogger<JokeService> logger)
        {
            _unitOfWorkProvider = unitOfWorkProvider ?? throw new ArgumentNullException(nameof(unitOfWorkProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<Joke>> GetAllJokesAsync()
        {
            using (var uow = _unitOfWorkProvider.CreateUnitOfWork())
            {
                var repository = uow.GetRepository<Joke>();
                return await repository.GetAllAsync(null);
            }
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
