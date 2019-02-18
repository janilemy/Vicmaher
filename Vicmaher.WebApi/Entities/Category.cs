using Platform.DAL.Entities;
using System.Collections.Generic;

namespace Vicmaher.WebServices.Entities
{
    public class Category : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Category Jokes.
        /// </summary>
        /// <value>
        /// Category jokes.
        /// </value>
        public ICollection<Joke> Jokes { get; set; }
    }
}
