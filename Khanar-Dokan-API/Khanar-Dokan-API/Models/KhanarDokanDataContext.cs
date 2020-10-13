using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class KhanarDokanDataContext:DbContext
    {
        public KhanarDokanDataContext()
        {
            Database.SetInitializer<KhanarDokanDataContext>(new DropCreateDatabaseIfModelChanges<KhanarDokanDataContext>());
        }

        virtual public DbSet<Category> Categories { get; set; }

        virtual public DbSet<Comment> Comments { get; set; }
        
        virtual public DbSet<Contact> Contacts { get; set; }
        
        virtual public DbSet<Employee> Employees { get; set; }

        virtual public DbSet<FoodItem> FoodItems { get; set; }
        
        virtual public DbSet<History> Histories { get; set; }

        virtual public DbSet<Inventory> Inventories { get; set; }
        
        virtual public DbSet<Invoice> Invoices { get; set; }

        virtual public DbSet<Order> Orders{ get; set; }
        
        virtual public DbSet<User> Users { get; set; }
    }
}