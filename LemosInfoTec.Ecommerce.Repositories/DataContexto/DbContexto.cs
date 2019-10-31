using System;
using Microsoft.EntityFrameworkCore;

namespace LemosInfoTec.Ecommerce.Repositories.DataContexto
{
    public class DbContexto:DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options)
        :base(options)
        {
            
        }

        public DbSet<usuarios> Usuarios{get;set;}
    }
}
