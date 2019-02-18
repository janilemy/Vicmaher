using Microsoft.Extensions.Logging;
using Platform.DAL.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vicmaher.WebApi.Services.Interfaces;
using Vicmaher.WebServices.Entities;

namespace Vicmaher.WebApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWorkProvider _unitOfWorkProvider;
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(
            IUnitOfWorkProvider unitOfWorkProvider,
            ILogger<CategoryService> logger)
        {
            _unitOfWorkProvider = unitOfWorkProvider ?? throw new ArgumentNullException(nameof(unitOfWorkProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            using (var uow = _unitOfWorkProvider.CreateUnitOfWork())
            {
                var repository = uow.GetRepository<Category>();
                return await repository.GetAllAsync(null);
            }
        }
    }
}
