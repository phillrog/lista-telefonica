﻿using System;
using System.Collections.Generic;
using System.Text;
using ListaTelefonica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ListaTelefonica.Infra.Data.EntityConfig
{
	public class PersonPhoneConfiguration : IEntityTypeConfiguration<PersonPhone>
	{
		public void Configure(EntityTypeBuilder<PersonPhone> builder)
		{
			builder.ToTable("PessoaTelefone");

			builder.HasKey(p => p.Id);

			builder.Property(p => p.Id).UseNpgsqlSerialColumn();

			builder.Property(p => p.Description)
				.IsRequired()
				.HasMaxLength(100);

			builder.Property(p => p.Number)
				.IsRequired()
				.HasMaxLength(20);

			builder.Property(p => p.PersonId);

			builder.HasOne(p => p.Person).WithMany(u => u.Phones).HasForeignKey( p=> p.PersonId);
		}
	}
}
