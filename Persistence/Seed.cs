using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.People.Any()) return;
            
            var person = new List<Person>
            {
                new Person
                {
                    Name = "Ali Ezadkhaha",                    
                    Phone = "0753685",
                },
               new Person
                {
                    Name = "Pary Darya",
                    Phone = "0987645",
                },
                new Person
                {
                    Name = "Sara Bady",
                    Phone = "0369852",
                },
                new Person
                {
                    Name = "Dara Esfehani",
                    Phone = "0568974",
                },
               new Person
                {
                    Name = "Sasan Miany",
                    Phone = "0325647",
                },
               new Person
                {
                    Name = "Sassi Shirazi",
                    Phone = "0457845",
                },
               new Person
                {
                    Name = "Akbar gholi",
                    Phone = "0546897",
                },
               new Person
                {
                    Name = "Sima Abdi",
                    Phone = "0125364",
                },
              new Person
                {
                    Name = "Billy Bardhyll",
                    Phone = "0356897",
                },
               new Person
                {
                    Name = "Benjamin Ezadkhaha",
                    Phone = "0325684",
                },
            };

            await context.People.AddRangeAsync(person);
            await context.SaveChangesAsync();
        }
    }
}