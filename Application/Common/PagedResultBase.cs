namespace Application.Common
{
    /// <summary>
    /// Describe the <see cref="PagedResultBase" /> with basic properties of paged results.
    /// </summary>
    public abstract class PagedResultBase
    {
        /// <summary>
        /// Gets or sets the CurrentPage.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the PageCount.
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Gets or sets the PageSize.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the RowCount.
        /// </summary>
        public int RowCount { get; set; }

        /// <summary>
        /// Gets the FirstRowOnPage.
        /// </summary>
        public int FirstRowOnPage => ((CurrentPage - 1) * PageSize) + 1;

        /// <summary>
        /// Gets the LastRowOnPage.
        /// </summary>
        public int LastRowOnPage => Math.Min(CurrentPage * PageSize, RowCount);
    }
}
