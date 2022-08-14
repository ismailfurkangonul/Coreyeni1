using Coreyeni.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coreyeni.Data.Config
{
    public class SalesHistoryConfig : IEntityTypeConfiguration<SalesHistory>
    {
        public void Configure(EntityTypeBuilder<SalesHistory> builder)
        {
            builder.HasOne(x => x.Product).WithMany(x => x.SalesHistory).HasForeignKey(x => x.ProductId);
        }
    }
}
