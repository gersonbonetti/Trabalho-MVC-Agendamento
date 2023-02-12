using Microsoft.EntityFrameworkCore;
using MVC_Agendamento_Domain.DTO;
using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Context {
    public class SQLServerContext : DbContext {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

         

            // Mapeamento de Relacionamento
            modelBuilder.Entity<Service>()
                .HasOne(service => service.Doctor)
                .WithMany(doctor => doctor.Service)
                .HasForeignKey(doctor => doctor.DoctorId);

            modelBuilder.Entity<Service>()
                .HasOne(service => service.Patient)
                .WithMany(patient => patient.Service)
                .HasForeignKey(patient => patient.PatientId);

            modelBuilder.Entity<Service>()
                .HasOne(service => service.Status)
                .WithMany(status => status.Service)
                .HasForeignKey(status => status.StatusId);

            modelBuilder.Entity<Schedule>()
                .HasOne(service => service.Doctor)
                .WithMany(doctor => doctor.Schedule)
                .HasForeignKey(doctor => doctor.DoctorId);

            modelBuilder.Entity<Schedule>()
                .HasOne(service => service.Patient)
                .WithMany(patient => patient.Schedule)
                .HasForeignKey(patient => patient.PatientId);

            modelBuilder.Entity<Schedule>()
               .HasOne(service => service.Status)
                .WithMany(status => status.Schedule)
                .HasForeignKey(status => status.StatusId);



            // Seed
            modelBuilder.Entity<Status>()
            .HasData(
            new { Id = 1, Name = "In attendance" },
            new { Id = 2, Name = "Waiting confirmation" },
            new { Id = 3, Name = "Marked" },
            new { Id = 4, Name = "Answered" },
            new { Id = 5, Name = "Filed" }
            );


            // Seed
            modelBuilder.Entity<Specialty>()
                .HasData(
                new { Id = 1, Name = "Pediatric" },
                new { Id = 2, Name = "Cardiology" },
                new { Id = 3, Name = "Dermatology" },
                new { Id = 4, Name = "Gastroenterology" }
                );

            modelBuilder.Entity<Person>()
                .HasData(
                new { Id = 1, Name = "Maria Clara de Souza", Age = "25", CPF = "123.456.789-12" },
                new { Id = 2, Name = "Paulo Moreira", Age = "47", CPF = "789.456.123-78" },
                new { Id = 3, Name = "Rafaella Rodrigues da Silva", Age = "16", CPF = "753.159.456-58" },
                new { Id = 4, Name = "João de Oliveira", Age = "52", CPF = "951.357.321-56" },
                new { Id = 5, Name = "Clara Maria Moretti", Age = "24", CPF = "741.852.963-37" },
                new { Id = 6, Name = "Ricardo Alves de Souza", Age = "31", CPF = "963.852.741-15" },
                new { Id = 7, Name = "Helena Muller", Age = "27", CPF = "248.862.176-49" },
                new { Id = 8, Name = "Gabriel Bugmann Vanzuita", Age = "40", CPF = "154.268.729-16" },
                new { Id = 9, Name = "Laura Elena Fisher", Age = "38", CPF = "217.369.252-98" }
                );

            modelBuilder.Entity<Patient>()
                .HasData(
                new { Id = 1, PersonId = 1, },
                new { Id = 2, PersonId = 2, },
                new { Id = 3, PersonId = 3, }
                );

            modelBuilder.Entity<Doctor>()
                .HasData(
                new { Id = 1, PersonId = 4, SpecialtyId = 4, CNPJ = "12.234.567/0001-89", CRM = "CRM/SP 123456" },
                new { Id = 2, PersonId = 5, SpecialtyId = 1, CNPJ = "56.741.963/0001-42", CRM = "CRM/SC 456983" },
                new { Id = 3, PersonId = 6, SpecialtyId = 2, CNPJ = "89.466.123/0001-26", CRM = "CRM/RS 123147" }
                );

           
            base.OnModelCreating(modelBuilder);


        }

        public SQLServerContext() : base() { }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
