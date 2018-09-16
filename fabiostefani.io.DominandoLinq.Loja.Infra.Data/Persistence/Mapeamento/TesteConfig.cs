using fabiostefani.io.DominandoLinq.Loja.Infra.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.Loja.Infra.Data.Persistence.Mapeamento
{
    public class TesteConfig : EntityTypeConfiguration<Teste>
    {
        public TesteConfig()
        {
            ToTable("TESTE");

            Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            Property(x => x.Nome)
                .HasColumnName("Nome")                
                .IsRequired();
        }
    }
}
