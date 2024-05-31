using Microsoft.EntityFrameworkCore;
public class Librarycontext : DbContext 
{
    public Librarycontext(DbContextOptions<Librarycontext> options) : base (options)
    {

    }

    public DbSet<Book> Books {get; set;}
}