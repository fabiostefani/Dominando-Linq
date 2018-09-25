using fabiostefani.io.DominandoLinq.BancoDados.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.BancoDados.Persistence.Map
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("PRODUTO");

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .IsRequired();

            Property(x => x.IdCategoria)
                .HasColumnName("IdCategoria")
                .IsRequired();

            Property(x => x.Valor)
                .HasColumnName("Valor")
                .IsRequired();

            HasRequired(x => x.Categoria)
                .WithMany()
                .HasForeignKey(x => x.IdCategoria);                
        }
    }
}
