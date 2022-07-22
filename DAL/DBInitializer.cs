using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD.Models;

namespace CRUD.DAL
{
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var persons = new List<Person>
            {
                new Person{Imie="Filip", Nazwisko="Kowalski", Opis="Hello, I love this application"},
                new Person{Imie="Mateusz", Nazwisko="Kowalski", Opis="Hello, I love this application"},
                new Person{Imie="Ania", Nazwisko="Kowalska", Opis="Hello, I love this application"},
                new Person{Imie="Basia", Nazwisko="Kowalska", Opis="Hello, I love this application"},
                new Person{Imie="Wojciech", Nazwisko="Kowalski", Opis="Hello, I love this application"}
            };

            persons.ForEach(p => context.Persons.Add(p));
            context.SaveChanges();

            var emails = new List<Email>
            {
                new Email{PersonId=1, EmailContent="hey21@gmail.com"},
                new Email{PersonId=2, EmailContent="hello13@gmail.com"},
                new Email{PersonId=3, EmailContent="hi33@gmail.com"},
                new Email{PersonId=4, EmailContent="witam122@gmail.com"},
                new Email{PersonId=5, EmailContent="czesc1@gmail.com"},
            };
            emails.ForEach(c => context.Emails.Add(c));
            context.SaveChanges();
        }
    }
}