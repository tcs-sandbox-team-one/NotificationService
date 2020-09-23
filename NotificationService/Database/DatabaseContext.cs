using Microsoft.EntityFrameworkCore;
using NotificationService.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationService.Database
{
    public class DatabaseContext: DbContext
    {
        internal object notification;

        public DbSet<notification> Notifications { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=ts-management-db; port=3306; database=notificationdb; user=root; password=password");
        }
    }
}
