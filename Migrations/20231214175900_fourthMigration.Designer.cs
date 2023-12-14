﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using thirdProject.Models;

#nullable disable

namespace thirdProject.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231214175900_fourthMigration")]
    partial class fourthMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("thirdProject.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("thirdProject.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Percentual")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("thirdProject.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("thirdProject.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Cancelar")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Devolver")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("PagamentoId");

                    b.ToTable("NotaDeVenda");
                });

            modelBuilder.Entity("thirdProject.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("thirdProject.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("thirdProject.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("TipoDePagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("thirdProject.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Transportadora");
                });

            modelBuilder.Entity("thirdProject.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("thirdProject.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("thirdProject.Models.TipoDePagamento");

                    b.Property<string>("Bandeira")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCartao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("thirdProject.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("thirdProject.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("thirdProject.Models.Cliente", b =>
                {
                    b.HasOne("thirdProject.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Cliente")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("thirdProject.Models.Marca", b =>
                {
                    b.HasOne("thirdProject.Models.Produto", "Produto")
                        .WithMany("Marca")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("thirdProject.Models.NotaDeVenda", b =>
                {
                    b.HasOne("thirdProject.Models.Item", "Item")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("ItemId");

                    b.HasOne("thirdProject.Models.Pagamento", "Pagamento")
                        .WithMany("NotaDeVenda")
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("thirdProject.Models.Produto", b =>
                {
                    b.HasOne("thirdProject.Models.Item", "Item")
                        .WithMany("Produto")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("thirdProject.Models.TipoDePagamento", b =>
                {
                    b.HasOne("thirdProject.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("TipoDePagamento")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("thirdProject.Models.Transportadora", b =>
                {
                    b.HasOne("thirdProject.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Transportadora")
                        .HasForeignKey("NotaDeVendaId");

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("thirdProject.Models.Vendedor", b =>
                {
                    b.HasOne("thirdProject.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Vendedor")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("thirdProject.Models.Item", b =>
                {
                    b.Navigation("NotaDeVendas");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("thirdProject.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Cliente");

                    b.Navigation("TipoDePagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("thirdProject.Models.Pagamento", b =>
                {
                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("thirdProject.Models.Produto", b =>
                {
                    b.Navigation("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}
