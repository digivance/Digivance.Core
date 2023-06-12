namespace Digivance.Core.Models
{
    /// <summary>
    /// BaseModel represents common fields used on all of the Digivance App Kit
    /// model objects.
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Unique id of the user who created this model
        /// </summary>
        public int CreatedById { get; set; }

        /// <summary>
        /// UTC Date time when this model was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Unique id of this model
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Unique id of the user who last modified this model
        /// </summary>
        public int ModifiedById { get; set; }

        /// <summary>
        /// UTC Date time when this model was last modified
        /// </summary>
        public int ModifiedDate { get; set; }
    }
}
