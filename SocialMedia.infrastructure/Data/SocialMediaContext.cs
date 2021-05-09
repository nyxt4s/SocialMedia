using System;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Infrastructure.Data.Configuration;


#nullable disable

namespace SocialMedia.Infrastructure.Data
{
    public partial class SocialMediaContext : DbContext
    {
        public SocialMediaContext()
        {
        }

        public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
            : base(options)
        {
        }

        //entity framework piensa que al momento de utilizar el DBSet el nombre de la variable que le daremos sera el mismo
        //que el nombre de la tabla de la base de datos, por ello ahora que lo traducimos hay que mapearlo
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

//       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            //mapeo comentario
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            //mapeo publicacion
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            //mapeo usuarios
            modelBuilder.ApplyConfiguration(new UserConfiguration());
           
        }
    }
}
