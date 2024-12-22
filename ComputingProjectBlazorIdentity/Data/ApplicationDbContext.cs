using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ComputingProjectBlazorIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace ComputingProjectBlazorIdentity.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ComputingProjectBlazorIdentity.Models.Quiz> Quiz { get; set; } = default!;
        public DbSet<QuizResult> QuizResults { get; set; }
    }
}
