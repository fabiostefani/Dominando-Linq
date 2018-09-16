using fabiostefani.io.DominandoLinq.Loja.Infra.Data.Entidades;
using fabiostefani.io.DominandoLinq.Loja.Infra.Data.Persistence.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.Loja.Infra.Data.Persistence
{
    public class LojaContext : DbContext
    {
        public LojaContext()
            :base("Loja2")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Categoria> Categoria { get; set; }
        public IDbSet<Produto> Produto { get; set; }
        public IDbSet<Teste> Teste { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //seta o Schema default
            //modelBuilder.HasDefaultSchema("Apoio");

            //remove a pluralização dos nomes das tabelas
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
            modelBuilder.Configurations.Add(new TesteConfig());

            //#region Adiciona entidades mapeadas - automaticamente via assemlby
            //modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);
            //#endregion

            #region Adiciona entidades mapeadas - Automaticamente via NameSpacep

            //Assembly.GetExecutingAssembly().GetTypes()
            //    .Where(type => type.Namespace == "fabiostefani.io.XGame.Domain.Entities")
            //    .ToList()
            //    .ForEach(type =>
            //    {
            //        dynamic instance = Activator.CreateInstance(type);
            //        modelBuilder.Configurations.Add(instance);
            //    });

            #endregion


            base.OnModelCreating(modelBuilder);
        }
    }
}
