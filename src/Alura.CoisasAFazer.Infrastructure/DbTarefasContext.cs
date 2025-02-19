﻿using Alura.CoisasAFazer.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura.CoisasAFazer.Infrastructure
{
    public class DbTarefasContext : DbContext
    {
        public DbTarefasContext(DbContextOptions options) : base(options)
        {
        }

        public DbTarefasContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DbTarefas;Trusted_Connection=True;");
        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
