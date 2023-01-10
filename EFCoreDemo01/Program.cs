using System;
using System.Threading.Tasks;

namespace EFCoreDemo01
{
    class Program
    {
        //https://blog.jetbrains.com/dotnet/2017/08/09/running-entity-framework-core-commands-rider/
        //dotnet ef migrations add init
        // dotnet ef database update

        static async Task Main(string[] args)
        {
            using (var testDbContext = new TestDbContext())
            {
                var book = new Book()
                {
                    Title = "This is a book",
                    AuthorName = "My",
                    Price = 123,
                    PubTime = DateTime.Now
                };
                testDbContext.Books.Add(book);
                await testDbContext.SaveChangesAsync();
            }
            
        }
        
    }
}