#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppASPMVCConRazor.Models;

namespace WebAppASPMVCConRazor.Data
{
    public class WebAppASPMVCConRazorContext : DbContext
    {
        public WebAppASPMVCConRazorContext (DbContextOptions<WebAppASPMVCConRazorContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppASPMVCConRazor.Models.Movie> Movie { get; set; }
    }
}
