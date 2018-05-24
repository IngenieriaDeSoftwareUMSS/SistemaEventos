using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class sistema_eventosContext : DbContext
    {
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Galeria> Galeria { get; set; }
        public virtual DbSet<ListaAmigos> ListaAmigos { get; set; }
        public virtual DbSet<ListaCategorias> ListaCategorias { get; set; }
        public virtual DbSet<UsuarioEvento> UsuarioEvento { get; set; }
        public virtual DbSet<UsuarioRegistrado> UsuarioRegistrado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=sistema_eventos;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("CATEGORIA");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("ID_CATEGORIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColorCategoria)
                    .IsRequired()
                    .HasColumnName("COLOR_CATEGORIA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCategoria)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION_CATEGORIA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CATEGORIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.IdEvento);

                entity.ToTable("EVENTO");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("ID_EVENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CostoEvento)
                    .HasColumnName("COSTO_EVENTO")
                    .HasColumnType("money");

                entity.Property(e => e.DescripcionEvento)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION_EVENTO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionEvento)
                    .IsRequired()
                    .HasColumnName("DIRECCION_EVENTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin)
                    .HasColumnName("FECHA_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("FECHA_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MapaLatitud).HasColumnName("MAPA_LATITUD");

                entity.Property(e => e.MapaLongitud).HasColumnName("MAPA_LONGITUD");

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasColumnName("NOMBRE_EVENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Galeria>(entity =>
            {
                entity.HasKey(e => e.IdGaleria);

                entity.ToTable("GALERIA");

                entity.Property(e => e.IdGaleria)
                    .HasColumnName("ID_GALERIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdEvento).HasColumnName("ID_EVENTO");

                entity.Property(e => e.ImagenEvento)
                    .IsRequired()
                    .HasColumnName("IMAGEN_EVENTO")
                    .HasColumnType("image");

                entity.HasOne(d => d.IdEventoNavigation)
                    .WithMany(p => p.Galeria)
                    .HasForeignKey(d => d.IdEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GALERIA_EVENTO");
            });

            modelBuilder.Entity<ListaAmigos>(entity =>
            {
                entity.HasKey(e => new { e.IdAmigo, e.IdUsuario });

                entity.ToTable("LISTA_AMIGOS");

                entity.Property(e => e.IdAmigo).HasColumnName("ID_AMIGO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdAmigoNavigation)
                    .WithMany(p => p.ListaAmigosIdAmigoNavigation)
                    .HasForeignKey(d => d.IdAmigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LISTA_USUARIO_AMIGOS");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ListaAmigosIdUsuarioNavigation)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LISTA_AMIGOS");
            });

            modelBuilder.Entity<ListaCategorias>(entity =>
            {
                entity.HasKey(e => new { e.IdEvento, e.IdCategoria });

                entity.ToTable("LISTA_CATEGORIAS");

                entity.Property(e => e.IdEvento).HasColumnName("ID_EVENTO");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.ListaCategorias)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVENTO_CATEGORIA");

                entity.HasOne(d => d.IdEventoNavigation)
                    .WithMany(p => p.ListaCategorias)
                    .HasForeignKey(d => d.IdEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORIA_EVENTO");
            });

            modelBuilder.Entity<UsuarioEvento>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.IdEvento });

                entity.ToTable("USUARIO_EVENTO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.IdEvento).HasColumnName("ID_EVENTO");

                entity.Property(e => e.Creador).HasColumnName("CREADOR");

                entity.HasOne(d => d.IdEventoNavigation)
                    .WithMany(p => p.UsuarioEvento)
                    .HasForeignKey(d => d.IdEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_EVENTO");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioEvento)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVENTO_USUARIO");
            });

            modelBuilder.Entity<UsuarioRegistrado>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("USUARIO_REGISTRADO");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_USUARIO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApellidoUsuario)
                    .IsRequired()
                    .HasColumnName("APELLIDO_USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("FECHA_NACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MailUsuario)
                    .IsRequired()
                    .HasColumnName("MAIL_USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("NOMBRE_USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
