public class CodeManagerContext : DbContext
{
    public DbSet<CodeFile> CodeFiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=code_manager.db");
    }

    public void EnsureDatabaseCreated()
    {
        this.Database.EnsureCreated();
    }
}
using (var context = new CodeManagerContext())
{
    context.EnsureDatabaseCreated();
}
