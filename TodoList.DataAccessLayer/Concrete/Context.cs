using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.EntityLayer.Concrete;

namespace TodoList.DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }

    }
}
