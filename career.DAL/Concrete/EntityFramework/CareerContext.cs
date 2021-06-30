using career.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.Concrete.EntityFramework
{
    public class CareerContext:DbContext
    {
        public CareerContext(DbContextOptions<CareerContext> options):base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(user => user.UserId);
            modelBuilder.Entity<User>().HasQueryFilter(e => e.IsDeleted==false);

            modelBuilder.Entity<VacancyType>().HasKey(vacancy => vacancy.VacancyTypeId);

            modelBuilder.Entity<VacancyType>().HasData(
                new VacancyType {VacancyTypeId=1,IsDeleted=false,  Key="intern",Name="Təcrübə proqramı" },
                new VacancyType {VacancyTypeId=2,IsDeleted=false,  Key = "work", Name = "İş vakansiyası" }
                );


            modelBuilder.Entity<VacancyType>().HasQueryFilter(e => e.IsDeleted==false);




            modelBuilder.Entity<Position>().HasQueryFilter(e => e.IsDeleted == false);
            modelBuilder.Entity<Position>().HasData(
                new Position {PositionId=10,  Name= "Kiçik mütəxəssis", IsDeleted = false, DepartmantId =11  },
                new Position {PositionId=11,  Name= "Mütəxəssis", IsDeleted = false, DepartmantId =12  },
                new Position {PositionId=12,  Name = "Apararıcı mütəxəssis", IsDeleted = false, DepartmantId = 13 },
                new Position {PositionId=13,  Name = "Baş mütəxəssis", IsDeleted = false, DepartmantId = 12 },
                new Position {PositionId=14,  Name = "Sektor müdiri", IsDeleted = false, DepartmantId = 14 },
                new Position {PositionId=15,  Name = "Şöbə müdiri", IsDeleted = false, DepartmantId = 10 },
                new Position {PositionId=16,  Name = "Direktor müavini", IsDeleted = false, DepartmantId = 14 },
                new Position { PositionId = 17, Name = "Direktor", IsDeleted = false, DepartmantId = 13 }
                );



            modelBuilder.Entity<Departmant>().HasQueryFilter(e => e.IsDeleted == false);
            modelBuilder.Entity<Departmant>().HasData(
                new Departmant {DepartmantId=10, Name= "Layihələndirmə", IsDeleted = false, ParentDepartmantId =null },
                new Departmant {DepartmantId=11, Name= "Proqram təminatının hazırlanması", IsDeleted = false, ParentDepartmant =null  },
                new Departmant {DepartmantId=12,  Name = "Ümumi ", IsDeleted = false, ParentDepartmant = null },
                new Departmant {DepartmantId=13,  Name = "Verilənlər bazasının idarə edilməsi və şəbəkə inzibatçılığı", IsDeleted = false, ParentDepartmant = null },
                new Departmant { DepartmantId = 14, Name = "Maliyyə", IsDeleted = false, ParentDepartmant = null }
                );




            modelBuilder.Entity<Employee>().HasQueryFilter(e => e.IsDeleted == false);

            modelBuilder.Entity<Vacancy>().HasKey(vacancy => vacancy.VacancyId);
            modelBuilder.Entity<Vacancy>().HasQueryFilter(e => e.IsDeleted==false);


            modelBuilder.Entity<VacancyInformation>().HasKey(vacancy => vacancy.VacancyInfoId);
            modelBuilder.Entity<VacancyInformation>().HasQueryFilter(e => e.IsDeleted==false);


            modelBuilder.Entity<VacancyRequirement>().HasKey(vacancy => vacancy.VacancyRequirementId);
            modelBuilder.Entity<VacancyRequirement>().HasQueryFilter(e => e.IsDeleted==false);

        }

        public DbSet<User> Users { get; set; }
        public DbSet<VacancyType> VacancyTypes { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyInformation> VacancyInformation { get; set; }
        public DbSet<VacancyRequirement> VacancyRequirements { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Departmant> Departmants { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
