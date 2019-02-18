using Platform.DAL.Entities;

namespace Vicmaher.WebServices.Entities
{
    public class Joke : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// the title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        /// <value>
        /// the description.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets Joke Category.
        /// </summary>
        /// <value>
        /// Joke Category.
        /// </value>

        public Category Category { get; set; }
    }
}
