using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using T2208E__ASP.NET_MVC.Models;

namespace T2208E__ASP.NET_MVC.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
		public DbSet<T2208E__ASP.NET_MVC.Models.Department>? Department { get; set; }
		public DbSet<T2208E__ASP.NET_MVC.Models.Employee>? Employee { get; set; }
	}
}