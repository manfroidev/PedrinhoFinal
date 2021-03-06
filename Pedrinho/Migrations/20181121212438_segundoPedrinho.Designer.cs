﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pedrinho.Models;

namespace Pedrinho.Migrations
{
    [DbContext(typeof(PedrinhoContext))]
    [Migration("20181121212438_segundoPedrinho")]
    partial class segundoPedrinho
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pedrinho.Models.Bug", b =>
                {
                    b.Property<int>("bugId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("descricao");

                    b.Property<int>("enigmaId");

                    b.Property<int>("usuarioId");

                    b.HasKey("bugId");

                    b.ToTable("Bug");
                });

            modelBuilder.Entity("Pedrinho.Models.contato", b =>
                {
                    b.Property<int>("contatoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao");

                    b.Property<string>("nome");

                    b.Property<string>("usuarioId");

                    b.HasKey("contatoId");

                    b.ToTable("contato");
                });

            modelBuilder.Entity("Pedrinho.Models.Enigma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("resposta");

                    b.HasKey("id");

                    b.ToTable("Enigma");
                });

            modelBuilder.Entity("Pedrinho.Models.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.Property<string>("senha");

                    b.HasKey("usuarioId");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
