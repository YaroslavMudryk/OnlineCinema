using Microsoft.EntityFrameworkCore;
using OC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC.Infrastructure.Data.EF.Context
{
    public class CinemaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
