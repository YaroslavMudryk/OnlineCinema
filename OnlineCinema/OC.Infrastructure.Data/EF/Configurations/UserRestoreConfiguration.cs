using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC.Domain.Models;
namespace OC.Infrastructure.Data.EF.Configurations
{
    public class UserRestoreConfiguration : IEntityTypeConfiguration<UserRestore>
    {
        public void Configure(EntityTypeBuilder<UserRestore> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new
            {
                x.Code,
                x.CreatedAt,
                x.UserId
            });
        }
    }
}