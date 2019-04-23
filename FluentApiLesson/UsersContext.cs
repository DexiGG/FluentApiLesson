namespace FluentApiLesson
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UsersContext : DbContext
    {
        public UsersContext()
            : base("name=UsersContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }


        //2вариант изменени€ таблицы
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("_users");
            modelBuilder.Entity<User>().Property(user => user.Id); //–аботаем конк с ID
            modelBuilder.Entity<User>().HasKey(user => user.Id);
            modelBuilder.Entity<User>().Property(user => user.Login).HasColumnName("log").IsRequired();
            modelBuilder.Entity<User>().Property(user => user.Password).HasColumnName("_pass").IsRequired();

            //modelbuilder.entity<user>().hasmany(user => user.orders).withrequired(order => order.user);
        }

    }
}
