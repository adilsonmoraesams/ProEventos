using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {

        // Atribui a classe (base) o objeto com a connectionString passado na startup 
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Evento> Evento { get; set; }
        
    }
}