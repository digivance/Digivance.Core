using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digivance.Core.EntityFramework
{
    /// <summary>
    /// An extension method that will automatically configure the IAuditable fields
    /// of an entity.
    /// </summary>
    public static class EntityTypeBuilderExtensions
    {
        /// <summary>
        /// Configure entity framework for the IAuditable fields of an entity
        /// </summary>
        /// <param name="builder">The type builder to configure</param>
        public static void ConfigureAuditable(this EntityTypeBuilder builder)
        {
            builder.HasKey("Id");

            builder.Property("CreatedById")
                .HasColumnType("INT")
                .IsRequired();

            builder.Property("CreatedDate")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property("ModifiedById")
                .HasColumnType("INT")
                .IsRequired(false)
                .IsRequired();

            builder.Property("ModifiedDate")
                .HasColumnType("DATETIME")
                .IsRequired(false)
                .IsRequired();
        }
    }
}