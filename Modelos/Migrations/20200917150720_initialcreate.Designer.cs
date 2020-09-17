﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelos;

namespace Modelos.Migrations
{
    [DbContext(typeof(Bd))]
    [Migration("20200917150720_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoletimEscolar.Modelos.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IdCurso");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("BoletimEscolar.Modelos.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Situação")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("BoletimEscolar.Modelos.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situação")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCurso");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("BoletimEscolar.Modelos.Notas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunosId")
                        .HasColumnType("int");

                    b.Property<int>("IdAluno")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int?>("MateriasId")
                        .HasColumnType("int");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AlunosId");

                    b.HasIndex("MateriasId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("Modelos.Modelos.MateriaAluno", b =>
                {
                    b.Property<int>("IdAluno")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int?>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.HasKey("IdAluno", "IdMateria");

                    b.HasIndex("AlunoId");

                    b.HasIndex("MateriaId");

                    b.ToTable("MateriaAluno");
                });

            modelBuilder.Entity("BoletimEscolar.Modelos.Aluno", b =>
                {
                    b.HasOne("BoletimEscolar.Modelos.Curso", "Curso")
                        .WithMany("Alunos")
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoletimEscolar.Modelos.Materia", b =>
                {
                    b.HasOne("BoletimEscolar.Modelos.Curso", "Curso")
                        .WithMany("Materias")
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoletimEscolar.Modelos.Notas", b =>
                {
                    b.HasOne("BoletimEscolar.Modelos.Aluno", "Alunos")
                        .WithMany("Notas")
                        .HasForeignKey("AlunosId");

                    b.HasOne("BoletimEscolar.Modelos.Materia", "Materias")
                        .WithMany("Notas")
                        .HasForeignKey("MateriasId");
                });

            modelBuilder.Entity("Modelos.Modelos.MateriaAluno", b =>
                {
                    b.HasOne("BoletimEscolar.Modelos.Aluno", "Aluno")
                        .WithMany("Materias")
                        .HasForeignKey("AlunoId");

                    b.HasOne("BoletimEscolar.Modelos.Materia", "Materia")
                        .WithMany("alunos")
                        .HasForeignKey("MateriaId");
                });
#pragma warning restore 612, 618
        }
    }
}
