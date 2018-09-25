using fabiostefani.io.DominandoLinq.BancoDados.Entities;
using fabiostefani.io.DominandoLinq.BancoDados.Persistence.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.BancoDados.Persistence
{
    public class LojaContext : DbContext
    {
        public LojaContext()
            :base("Loja")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Categoria> Categoria { get; set; }
        public IDbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //setar para usar varchar ao invés de nvarchar
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            //caso eu esqueça de informar o tamanho do campo,  ele irá colocar varchar de 100
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(100));


            //mapeia as entidades
            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
