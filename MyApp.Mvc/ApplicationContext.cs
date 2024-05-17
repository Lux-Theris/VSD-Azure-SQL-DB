using Microsoft.EntityFrameworkCore;

public class ApplicationContext(DbContextOptions options) : DbContext(options){
  public DbSet<ToDo> ToDos { get; set; }
}