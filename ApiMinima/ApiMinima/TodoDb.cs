using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ApiMinima
{
    public class TodoDb : DbContext
    {
        public  TodoDb(DbContextOptions<TodoDb> options)
            : base(options)
        { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
