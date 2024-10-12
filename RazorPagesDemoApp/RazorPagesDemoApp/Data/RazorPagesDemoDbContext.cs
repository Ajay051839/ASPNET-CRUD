using Microsoft.EntityFrameworkCore;

namespace RazorPagesDemoApp.Data
{
    //This RazorPagesDemoDbContext class inherit from a base class DbContext
    public class RazorPagesDemoDbContext : DbContext
    {
        //2-Now we need to add constructor so that when we pass the options from Program.cs it comes down to Dbcontext
        //3-Shortcut for consttructor Go on class name press CTRL+.
        //4-We populate the DbContextOptions from Program.cs
        public RazorPagesDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        //5-define the property that Db class have
    }
}
