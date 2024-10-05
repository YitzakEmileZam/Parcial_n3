using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RemesasApp.Models;

namespace RemesasApp.Data
{
    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Remesa> Remesas { get; set; }
    public DbSet<ConversionMoneda> ConversionMonedas { get; set; }
    }
}