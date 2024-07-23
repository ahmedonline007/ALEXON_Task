using ALEXON_Task.DataEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ALEXON_Task.ConfigTable
{
    public class ProductConfig : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            //map default column using it like id,delete
            builder.ConfigureByConvention();
            builder.Property(x => x.Name).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();

            builder.HasOne(x => x.Category).WithMany()
                .HasForeignKey(x => x.CategoryId).IsRequired();
            builder.ToTable("Products");
        }
    }
}