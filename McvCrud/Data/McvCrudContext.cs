﻿using Microsoft.EntityFrameworkCore;

namespace McvCrud.Data
{
    public class McvCrudContext : DbContext
    {
        public McvCrudContext (DbContextOptions<McvCrudContext> options)
            : base(options)
        {
        }

        public DbSet<McvCrud.Models.Cadastro> Cadastro { get; set; }
    }
}
