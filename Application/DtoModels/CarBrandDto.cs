using System.ComponentModel.DataAnnotations;

namespace Application.DtoModels
{
    public class CarBrandDto
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Car brand name.
        /// </summary>
        public string Name { get; set; } = default!;
        /// <summary>
        /// Description brand, could be null.
        /// </summary>
        public string? Description { get; set; }
    }
}
