﻿using EuropArt.Domain.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropArt.Persistence.Data.Configuration
{
    public class ArtistEntityTypeConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.OwnsOne(p => p.Name, name =>
            {
                name.Property(n => n.FirstName).HasColumnName("Firstname").IsRequired();
                name.Property(n => n.LastName).HasColumnName("Lastname").IsRequired();
            }).Navigation(c => c.Name).IsRequired();

            builder.OwnsOne(c => c.Address, address =>
            {
                address.Property(a => a.Street).HasColumnName("Street").IsRequired();
                address.Property(a => a.Postalcode).HasColumnName("Postalcode").IsRequired();
                address.Property(a => a.City).HasColumnName("City").IsRequired();
                address.Property(a => a.Country).HasColumnName("Country").IsRequired();
            }).Navigation(c => c.Address).IsRequired();

            builder.HasMany(p => p.Artworks).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
