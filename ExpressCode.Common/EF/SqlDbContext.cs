using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;
namespace ExpressCode.Common
{
    public class SqlDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DBConfigHelper.ConnectSqlServer);
            base.OnConfiguring(optionsBuilder);
        }


        /// <summary>
        /// 表单
        /// </summary>
        public virtual DbSet<FormEntity> FormEntities { get; set; }

    }
}
