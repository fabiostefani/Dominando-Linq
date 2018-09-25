using fabiostefani.io.DominandoLinq.BancoDados.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.BancoDados.Persistence.Map
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            ToTable("CATEGORIA");

            Property(x => x.Nome)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
