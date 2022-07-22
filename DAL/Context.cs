using CRUD.Models;
using System.Data.Entity;

namespace CRUD.DAL
{
    //database context class
    public class Context : DbContext
    {
        //name of the connection string "Context" is passed into the constructor
        public Context() : base("Context")
        {
        }
        //dbset is an entity set which is table in sql and entity is a row
        public DbSet<Person> Persons { get; set; }
        public DbSet<Email> Emails { get; set; }
    }
}