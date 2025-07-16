using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickGridDemo.Data;

namespace QuickGridDemo.Data
{
    public class QuickGridDemoIdentityContext(DbContextOptions<QuickGridDemoIdentityContext> options) : IdentityDbContext<QuickGridDemoUser>(options)
    {
    }
}
