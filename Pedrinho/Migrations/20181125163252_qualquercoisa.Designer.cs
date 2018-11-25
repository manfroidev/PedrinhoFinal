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
    [Migration("20181125163252_qualquercoisa")]
    partial class qualquercoisa
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

                    b.Property<string>("descricao");

                    b.Property<int>("enigmaId");

                    b.Property<string>("resposta");

                    b.Property<int>("usuarioId");

                    b.HasKey("bugId");

                    b.ToTable("Bug");
                });

            modelBuilder.Entity("Pedrinho.Models.Contato", b =>
                {
                    b.Property<int>("contatoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("mensagem");

                    b.Property<string>("nome");

                    b.Property<string>("sobrenome");

                    b.Property<string>("telefone");

                    b.HasKey("contatoId");

                    b.ToTable("Contato");
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

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("nome")
                        .IsRequired();

                    b.Property<string>("senha")
                        .IsRequired();

                    b.Property<string>("tipoAcesso")
                        .IsRequired();

                    b.HasKey("usuarioId");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
