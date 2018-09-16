using fabiostefani.io.DominandoLinq.Loja.Infra.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace fabiostefani.io.DominandoLinq.Loja.Infra.Data.Persistence.Mapeamento
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            ToTable("CATEGORIA");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Nome");
        }
    }
}
