using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Atacado.EF.Database
{
    public partial class AtacadoContext : DbContext
    {
        public AtacadoContext()
        {
        }

        public AtacadoContext(DbContextOptions<AtacadoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaConhecimento> AreaConhecimentos { get; set; } = null!;
        public virtual DbSet<Banco> Bancos { get; set; } = null!;
        public virtual DbSet<Carrinho> Carrinhos { get; set; } = null!;
        public virtual DbSet<CarrinhoIten> CarrinhoItens { get; set; } = null!;
        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Curso> Cursos { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Distrito> Distritos { get; set; } = null!;
        public virtual DbSet<FormaEnvio> FormaEnvios { get; set; } = null!;
        public virtual DbSet<FormaPagto> FormaPagtos { get; set; } = null!;
        public virtual DbSet<FuncionarioDadosEmpresa> FuncionarioDadosEmpresas { get; set; } = null!;
        public virtual DbSet<FuncionarioDadosPessoai> FuncionarioDadosPessoais { get; set; } = null!;
        public virtual DbSet<FuncionarioTemp> FuncionarioTemps { get; set; } = null!;
        public virtual DbSet<Idioma> Idiomas { get; set; } = null!;
        public virtual DbSet<Mesoregiao> Mesoregiaos { get; set; } = null!;
        public virtual DbSet<Microregiao> Microregiaos { get; set; } = null!;
        public virtual DbSet<Municipio> Municipios { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<PrimeiroNome> PrimeiroNomes { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<Profissao> Profissaos { get; set; } = null!;
        public virtual DbSet<SubDistrito> SubDistritos { get; set; } = null!;
        public virtual DbSet<Subcategoria> Subcategorias { get; set; } = null!;
        public virtual DbSet<TipoFormaPagto> TipoFormaPagtos { get; set; } = null!;
        public virtual DbSet<TipoLogradouro> TipoLogradouros { get; set; } = null!;
        public virtual DbSet<UnidadesFederacao> UnidadesFederacaos { get; set; } = null!;
        public virtual DbSet<VwExibirProdutosComDetalhe> VwExibirProdutosComDetalhes { get; set; } = null!;
        public virtual DbSet<VwFuncionariosAtivosInformacao> VwFuncionariosAtivosInformacaos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=Atacado202204;User Id=sa;Password=senha123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaConhecimento>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Carrinho>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Carrinhos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedido_Carrinho");
            });

            modelBuilder.Entity<CarrinhoIten>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCarrinhoNavigation)
                    .WithMany(p => p.CarrinhoItens)
                    .HasForeignKey(d => d.IdCarrinho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrinho_Carrinho_Itens");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.CarrinhoItens)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_Carrinho_Itens");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });


            //Para permitir renomear as tabelas de maneira adequada em PT-BR, Singular ou Plural,
            //use o seguinte código:
            //protected override void OnModelCreating(DbModelBuilder modelBuilder)
            //{
            //    //Changing Database table name to Metadata
            //    modelBuilder.Entity<Metadata1>().ToTable("Metadata2"); // <--------------------
            //}
            //Onde
            //- Metadata1 - nome da classe no programa (geralmente no singular).
            //- Metadata2 - nome da tabela do banco.
            modelBuilder.Entity<Categoria>().ToTable("Categoria");


            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepto)
                    .HasName("PK_Depto");

                entity.Property(e => e.IdDepto).ValueGeneratedNever();

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaUf).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SiglaUfNavigation)
                    .WithMany(p => p.Distritos)
                    .HasPrincipalKey(p => p.SiglaUf)
                    .HasForeignKey(d => d.SiglaUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Distrito_UF");
            });

            modelBuilder.Entity<FormaEnvio>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FormaPagto>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdTipoFormaPagtoNavigation)
                    .WithMany(p => p.FormaPagtos)
                    .HasForeignKey(d => d.IdTipoFormaPagto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tipo_Forma_Pagto_Forma_Pagto");
            });

            modelBuilder.Entity<FuncionarioDadosEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdFuncDadosEmpresa)
                    .HasName("PK_FuncDadosEmpresa");

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FuncionarioDadosPessoai>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK_FuncDadosPessoais");

                entity.Property(e => e.IdFuncionario).ValueGeneratedNever();

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SexoFuncionario).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FuncionarioTemp>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK_FuncTemp");

                entity.Property(e => e.IdFuncionario).ValueGeneratedNever();

                entity.Property(e => e.SexoFuncionario).IsFixedLength();
            });

            modelBuilder.Entity<Idioma>(entity =>
            {
                entity.Property(e => e.AbreviadoIdioma).IsFixedLength();

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Mesoregiao>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaUf).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SiglaUfNavigation)
                    .WithMany(p => p.Mesoregiaos)
                    .HasPrincipalKey(p => p.SiglaUf)
                    .HasForeignKey(d => d.SiglaUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UF");
            });

            modelBuilder.Entity<Microregiao>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaUf).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SiglaUfNavigation)
                    .WithMany(p => p.Microregiaos)
                    .HasPrincipalKey(p => p.SiglaUf)
                    .HasForeignKey(d => d.SiglaUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Microregiao_UF");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.Property(e => e.IdMunicipio).ValueGeneratedNever();

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaUf).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdUfNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.IdUf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Municipio_UF");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.Property(e => e.CodIdioma).IsFixedLength();

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaPais).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Pedido");

                entity.HasOne(d => d.IdFormaEnvioNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdFormaEnvio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forma_Envio_Pedido");

                entity.HasOne(d => d.IdFormaPagtoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdFormaPagto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forma_Pagto_Pedido");
            });

            modelBuilder.Entity<PrimeiroNome>(entity =>
            {
                entity.HasKey(e => e.IdPriNome)
                    .HasName("PK_PriNome");

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SexoPriNome).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdSubcategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subcategoria_Produto");
            });

            modelBuilder.Entity<Profissao>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SubDistrito>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaUf).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SiglaUfNavigation)
                    .WithMany(p => p.SubDistritos)
                    .HasPrincipalKey(p => p.SiglaUf)
                    .HasForeignKey(d => d.SiglaUf)
                    .HasConstraintName("FK_SubDistrito_UF");
            });

            modelBuilder.Entity<Subcategoria>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Subcategoria)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subcategoria_Categoria");
            });

            modelBuilder.Entity<Subcategoria>().ToTable("Subcategoria");

            modelBuilder.Entity<TipoFormaPagto>(entity =>
            {
                entity.Property(e => e.IdTipoFormaPagto).ValueGeneratedNever();

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TipoLogradouro>(entity =>
            {
                entity.HasKey(e => e.IdTipoLog)
                    .HasName("PK_TipoLog");

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UnidadesFederacao>(entity =>
            {
                entity.HasKey(e => e.IdUf)
                    .HasName("PK_UF");

                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SiglaUf).IsFixedLength();

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<VwExibirProdutosComDetalhe>(entity =>
            {
                entity.ToView("VW_Exibir_Produtos_Com_Detalhes");
            });

            modelBuilder.Entity<VwFuncionariosAtivosInformacao>(entity =>
            {
                entity.ToView("VW_Funcionarios_Ativos_Informacao");

                entity.Property(e => e.SexoFuncionario).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
