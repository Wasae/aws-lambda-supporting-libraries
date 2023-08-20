using apollo_Business_Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace apollo_EFContext;
public class EFContext : DbContext
{
    private string connectionstring = "";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionstring);
    }

    public virtual DbSet<mst_user> mst_user { get;set;}
}
