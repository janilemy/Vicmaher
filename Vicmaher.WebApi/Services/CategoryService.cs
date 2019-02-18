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

        public CategoryService(IUnitOfWorkProvider unitOfWorkProvider)
        {
            _unitOfWorkProvider = unitOfWorkProvider ?? throw new ArgumentNullException(nameof(unitOfWorkProvider));
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
