namespace Digivance.Core
{
    /// <summary>
    /// Used to indicate that an object has basic auditing fields.
    /// </summary>
    public interface IAuditable
    {
        /// <summary>
        /// Unique id of the user who created this record
        /// </summary>
        public int CreatedById { get; set; }

        /// <summary>
        /// UTC Date time when this record was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Unique id of this record
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Unique id of the user who last modified this record
        /// </summary>
        public int ModifiedById { get; set; }

        /// <summary>
        /// UTC Date time when this record was last modified
        /// </summary>
        public int ModifiedDate { get; set; }
    }
}
