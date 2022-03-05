
using Microsoft.EntityFrameworkCore;
using Tarea_6.Entidades;

namespace Tarea_6.DAL{

    public class Contexto : DbContext
    {
       public DbSet<Productos> Productos {get; set;}

       public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}