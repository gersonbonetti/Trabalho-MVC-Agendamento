﻿// <auto-generated />
using System;
using MVC_Agendamento_Infra_Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCAgendamentoInfraData.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    [Migration("20230215220722_RenameService")]
    partial class RenameService
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNPJ = "12.234.567/0001-89",
                            CRM = "CRM/SP 123456",
                            PersonId = 4,
                            SpecialtyId = 4
                        },
                        new
                        {
                            Id = 2,
                            CNPJ = "56.741.963/0001-42",
                            CRM = "CRM/SC 456983",
                            PersonId = 5,
                            SpecialtyId = 1
                        },
                        new
                        {
                            Id = 3,
                            CNPJ = "89.466.123/0001-26",
                            CRM = "CRM/RS 123147",
                            PersonId = 6,
                            SpecialtyId = 2
                        });
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PersonId = 1
                        },
                        new
                        {
                            Id = 2,
                            PersonId = 2
                        },
                        new
                        {
                            Id = 3,
                            PersonId = 3
                        });
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = "25",
                            CPF = "123.456.789-12",
                            Name = "Maria Clara de Souza"
                        },
                        new
                        {
                            Id = 2,
                            Age = "47",
                            CPF = "789.456.123-78",
                            Name = "Paulo Moreira"
                        },
                        new
                        {
                            Id = 3,
                            Age = "16",
                            CPF = "753.159.456-58",
                            Name = "Rafaella Rodrigues da Silva"
                        },
                        new
                        {
                            Id = 4,
                            Age = "52",
                            CPF = "951.357.321-56",
                            Name = "João de Oliveira"
                        },
                        new
                        {
                            Id = 5,
                            Age = "24",
                            CPF = "741.852.963-37",
                            Name = "Clara Maria Moretti"
                        },
                        new
                        {
                            Id = 6,
                            Age = "31",
                            CPF = "963.852.741-15",
                            Name = "Ricardo Alves de Souza"
                        },
                        new
                        {
                            Id = 7,
                            Age = "27",
                            CPF = "248.862.176-49",
                            Name = "Helena Muller"
                        },
                        new
                        {
                            Id = 8,
                            Age = "40",
                            CPF = "154.268.729-16",
                            Name = "Gabriel Bugmann Vanzuita"
                        },
                        new
                        {
                            Id = 9,
                            Age = "38",
                            CPF = "217.369.252-98",
                            Name = "Laura Elena Fisher"
                        });
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ConfirmedQuery")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("StatusId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Evaluation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicalRecord")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceNumber")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("StatusId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pediatric"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cardiology"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dermatology"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gastroenterology"
                        });
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Em atendimento"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aguardando confirmação"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marcada"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Atendido"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Arquivado"
                        });
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Doctor", b =>
                {
                    b.HasOne("MVC_Agendamento_Domain.Entities.Specialty", "SpecialtyList")
                        .WithMany("DoctorList")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecialtyList");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Patient", b =>
                {
                    b.HasOne("MVC_Agendamento_Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Schedule", b =>
                {
                    b.HasOne("MVC_Agendamento_Domain.Entities.Doctor", "Doctor")
                        .WithMany("Schedule")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Agendamento_Domain.Entities.Patient", "Patient")
                        .WithMany("Schedule")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Agendamento_Domain.Entities.Status", "Status")
                        .WithMany("Schedule")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Service", b =>
                {
                    b.HasOne("MVC_Agendamento_Domain.Entities.Doctor", "Doctor")
                        .WithMany("Service")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Agendamento_Domain.Entities.Patient", "Patient")
                        .WithMany("Service")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Agendamento_Domain.Entities.Status", "Status")
                        .WithMany("Service")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.User", b =>
                {
                    b.HasOne("MVC_Agendamento_Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Doctor", b =>
                {
                    b.Navigation("Schedule");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Patient", b =>
                {
                    b.Navigation("Schedule");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Specialty", b =>
                {
                    b.Navigation("DoctorList");
                });

            modelBuilder.Entity("MVC_Agendamento_Domain.Entities.Status", b =>
                {
                    b.Navigation("Schedule");

                    b.Navigation("Service");
                });
#pragma warning restore 612, 618
        }
    }
}