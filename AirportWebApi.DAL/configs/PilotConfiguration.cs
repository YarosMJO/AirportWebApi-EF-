
using AirportWebApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirportWebApi.DAL.configs
{
    public class PilotConfiguration : IEntityTypeConfiguration<Pilot>
    {
        public void Configure(EntityTypeBuilder<Pilot> builder)
        {
            builder.ToTable("Pilots").HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
        }
    }
}
