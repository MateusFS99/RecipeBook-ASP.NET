﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBook_ASP.NET.Data;

#nullable disable

namespace RecipeBook_ASP.NET.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("RecipeBook_ASP.NET.Models.Ingrediente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("ingredientes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Feijão"
                        },
                        new
                        {
                            id = 2,
                            nome = "Fubá"
                        },
                        new
                        {
                            id = 3,
                            nome = "Chocolate"
                        },
                        new
                        {
                            id = 4,
                            nome = "Farinha"
                        });
                });

            modelBuilder.Entity("RecipeBook_ASP.NET.Models.Receita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("instrucoes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("receitas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            instrucoes = "",
                            titulo = "Feijoada"
                        },
                        new
                        {
                            id = 2,
                            instrucoes = "",
                            titulo = "Cuzcuz"
                        },
                        new
                        {
                            id = 3,
                            instrucoes = "",
                            titulo = "Brigadeiro"
                        },
                        new
                        {
                            id = 4,
                            instrucoes = "",
                            titulo = "Bolo de Chocolate"
                        });
                });

            modelBuilder.Entity("RecipeBook_ASP.NET.Models.ReceitaIngrediente", b =>
                {
                    b.Property<int>("receitaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ingredienteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("receitaId", "ingredienteId");

                    b.HasIndex("ingredienteId");

                    b.ToTable("receitasIngredientes");

                    b.HasData(
                        new
                        {
                            receitaId = 1,
                            ingredienteId = 1
                        },
                        new
                        {
                            receitaId = 2,
                            ingredienteId = 2
                        },
                        new
                        {
                            receitaId = 3,
                            ingredienteId = 3
                        },
                        new
                        {
                            receitaId = 4,
                            ingredienteId = 3
                        },
                        new
                        {
                            receitaId = 4,
                            ingredienteId = 4
                        });
                });

            modelBuilder.Entity("RecipeBook_ASP.NET.Models.ReceitaIngrediente", b =>
                {
                    b.HasOne("RecipeBook_ASP.NET.Models.Ingrediente", "ingrediente")
                        .WithMany()
                        .HasForeignKey("ingredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBook_ASP.NET.Models.Receita", "receita")
                        .WithMany()
                        .HasForeignKey("receitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ingrediente");

                    b.Navigation("receita");
                });
#pragma warning restore 612, 618
        }
    }
}