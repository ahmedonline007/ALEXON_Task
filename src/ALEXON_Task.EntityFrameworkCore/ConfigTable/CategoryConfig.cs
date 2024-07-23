using ALEXON_Task.DataEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ALEXON_Task.ConfigTable
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //map default column using it like id,delete
            builder.ConfigureByConvention();
            //insert manual of Id
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Name).HasMaxLength(500).IsRequired();

            builder.ToTable("Category");
        }
    }
}
