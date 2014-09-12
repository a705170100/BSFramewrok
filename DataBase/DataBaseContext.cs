﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatabaseModels;
namespace DataBase
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("default")
        {
           
            //是否启用延迟加载:  
            //  true:   延迟加载（Lazy Loading）：获取实体时不会加载其导航属性，一旦用到导航属性就会自动加载  
            //  false:  直接加载（Eager loading）：通过 Include 之类的方法显示加载导航属性，获取实体时会即时加载通过 Include 指定的导航属性  
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = true;  //自动监测变化，默认值为 true  
        }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserModels> UserContext { get; set; }
        public DbSet<PigModels> PigContext { get; set; }
    }
}
