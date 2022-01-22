using Microsoft.EntityFrameworkCore;
using ServernewRUB.DataAccess.Core.Interfaces.DbcContext;
using ServernewRUB.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServernewRUB.DataAccess.DbContext
{
    public class RubicConext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    
    {
        public RubicConext(DbContextOptions<RubicConext> options)
           : base(options)
        {

        }

        public DbSet<UserRto> Users { get; set; }


    }
}
