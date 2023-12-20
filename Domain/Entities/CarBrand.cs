using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    /// <summary>
    /// Entity Model for CarBrand
    /// </summary>
    public class CarBrand : IEntity
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Car brand name, is required.
        /// </summary>
        [Required]
        public string Name { get; set; } = default!;
        /// <summary>
        /// Description brand, could be null.
        /// </summary>
        public string? Description { get; set; }
    }
}
