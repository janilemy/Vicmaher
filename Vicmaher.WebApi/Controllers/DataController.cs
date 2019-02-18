using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Vicmaher.WebApi.Services;
using Vicmaher.WebApi.Services.Interfaces;

namespace Vicmaher.WebServices.Controllers
{
    /// <summary>
    /// Data controller service is used to exchange data between two systems.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : BaseController<DataController>
    {
        private IJokeService _jokeService { get; }
        private ICategoryService _categoryService { get; }

        /// <summary>
        ///   Initializes a new instance of the <see cref="DataController" /> class.
        /// </summary>
        /// <param name="logger">
        ///   The logger.
        /// </param>
        /// <param name="JokeServices">
        ///   The joke service.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   integrationDataService
        /// </exception>
        public DataController(
            ILogger<DataController> logger,
            IJokeService jokeService,
            ICategoryService categoryService) : base(logger)
        {
            _jokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }

        [HttpGet]
        [Route("getJokes")]
        public async Task<IActionResult> GetJokes()
        {
            var jokes = await _jokeService.GetAllJokesAsync();
            return Ok(jokes);
        }

        [HttpGet]
        [Route("getJokesByCategoryId")]
        public async Task<IActionResult> GetJokesByCategoryId(int id)
        {
            var jokes = await _jokeService.GetAllJokesByCategoryIdAsync(id);
            return Ok(jokes);
        }

        [HttpGet]
        [Route("getCategories")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok(categories);
        }

        // TODO: samples ...

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
