namespace Digivance.Core.Models
{
    /// <summary>
    /// BaseModel represents common fields used on all of the Digivance App Kit
    /// model objects.
    /// </summary>
    public class BaseModel : IAuditable
    {
        /// <inheritdoc />
        public int CreatedById { get; set; }

        /// <inheritdoc />
        public DateTime CreatedDate { get; set; }

        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public int? ModifiedById { get; set; }

        /// <inheritdoc />
        public DateTime? ModifiedDate { get; set; }
    }
}
