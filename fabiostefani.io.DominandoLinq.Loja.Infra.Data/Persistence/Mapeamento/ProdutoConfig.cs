using fabiostefani.io.DominandoLinq.Loja.Infra.Data.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace fabiostefani.io.DominandoLinq.Loja.Infra.Data.Persistence.Mapeamento
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("PRODUTO");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            Property(x => x.IdCategoria)
                .HasColumnName("IdCategoria")
                .IsRequired();

            Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("Nome");

            Property(x => x.Valor)
                .HasColumnName("Valor")
                .IsRequired()
                .HasPrecision(15, 2);
        }
    }
}
