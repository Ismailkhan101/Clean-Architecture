using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalApp;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Infrastructure.Data
{
    public class MedicalAppDbContext:DbContext
    {
        public MedicalAppDbContext(DbContextOptions<MedicalAppDbContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
