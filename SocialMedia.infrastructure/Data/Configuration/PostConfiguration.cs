﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        //recibimos el metodo de la interfaz
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.PostId);

            builder.ToTable("Publicacion");

            builder.Property(e => e.PostId)
            .HasColumnName("IdPublicacion")
            .ValueGeneratedNever();

            builder.Property(e => e.UserId)
            .HasColumnName("IdUsuario")
            .ValueGeneratedNever();

            builder.Property(e => e.Description)
                .HasColumnName("Descripcion")
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.Date)
                .HasColumnName("Fecha")
                .HasColumnType("datetime");

            builder.Property(e => e.Image)
                .HasColumnName("Imagen")
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.HasOne(d => d.User)
                .WithMany(p => p.Post)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Publicacion_Usuario");
        }
    }
}
