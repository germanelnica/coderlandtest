namespace Application.Common
{
    /// <summary>
    /// Defines the <see cref="PagedResult{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public class PagedResult<T>
        : PagedResultBase
        where T : class
    {
        /// <summary>
        /// Gets or sets the Results.
        /// </summary>
        public IList<T> Results { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResult{T}"/> class.
        /// </summary>
        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}
