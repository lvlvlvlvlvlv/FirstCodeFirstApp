using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeFirstApp
{
   public class Context: DbContext
    {
        //public Context():base("name=FirstCodeFirstApp")
        //{
        //}

        public Context()
           : base("name=FirstCodeFirstApp")
        {
        }

        public DbSet<Donator> Donator { get; set; }


        public DbSet<PayWay> PayWays { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            //modelbuilder.Entity<Donator>().ToTable("Donators").HasKey(m => m.DonatorId);
            //modelbuilder.Entity<Donator>().Property(m => m.DonatorId).HasColumnName("Id");
            //modelbuilder.Entity<Donator>().Property(m => m.Name).IsRequired().IsUnicode().HasMaxLength(10);

            modelbuilder.Configurations.Add(new DonatorMap());

            modelBuilder.Configurations.Add(new DonatorTypeMap());
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelbuilder);
        }

    }
}
