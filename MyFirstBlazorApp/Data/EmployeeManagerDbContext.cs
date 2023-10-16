using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MyFirstBlazorApp.Data.Modals
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Department> Departments => Set<Department>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Finance" },
                new Department { Id = 2, Name = "Sales" },
                new Department { Id = 3, Name = "Marketing" },
                new Department { Id = 4, Name = "Human Resources" },
                new Department { Id = 5, Name = "IT" } );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 101, FirstName = "Dusty", LastName = "Shaw", DepartmentId = 2, IsDeveloper = true, ImageUrl = "piggy.jpg" },
                new Employee { Id = 111, FirstName = "Enoch", LastName = "Whitaker", DepartmentId = 2, IsDeveloper = true, ImageUrl = "Beaker.jpg" },
                new Employee { Id = 121, FirstName = "Garion", LastName = "Cox", DepartmentId = 4, IsDeveloper = true, ImageUrl = "kermit.jpg" },
                new Employee { Id = 131, FirstName = "Fozzie", LastName = "Bear", DepartmentId = 5, ImageUrl = "Fozzie_Bear.jpg" },
                new Employee { Id = 141, FirstName = "Gonzo", LastName = "The Great", DepartmentId = 2, ImageUrl = "Gonzo.jpg" },
                new Employee { Id = 151, FirstName = "Sam", LastName = "The Eagle", DepartmentId = 1, ImageUrl = "SamTheEagle.jpg" },
                new Employee { Id = 171, FirstName = "Beaker", LastName = "The Muppet", DepartmentId = 4, ImageUrl = "Beaker.jpg" },
                new Employee { Id = 181, FirstName = "Fozzie ", LastName = "Bear 2", DepartmentId = 5, ImageUrl = "Fozzie_Bear.jpg" },
                new Employee { Id = 191, FirstName = "Gonzo", LastName = "The Great 2", DepartmentId = 2, ImageUrl = "Gonzo.jpg" },
                new Employee { Id = 201, FirstName = "Sam", LastName = "The Eagle 2", DepartmentId = 1, ImageUrl = "SamTheEagle.jpg" },
                new Employee { Id = 211, FirstName = "Fried", LastName = "Pickle ?", DepartmentId = 4, ImageUrl = "Beaker.jpg" }
                ) ;
        }
    }
}
