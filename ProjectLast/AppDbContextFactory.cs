//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Configuration;
//using System.IO;

//namespace ProjectLast
//{
//    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
//    {
//        public AppDbContext CreateDbContext(string[] args)
//        {
//            // Hardcoded path to your appsettings.json
//            var basePath = Path.GetFullPath(@"C:\Users\User\source\repos\ProjectLast\ProjectLast");

//            var configuration = new ConfigurationBuilder()
//                .SetBasePath(basePath)
//                .AddJsonFile("appsettings.json")
//                .Build();

//            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
//            var connectionString = configuration.GetConnectionString("defaultConnection");
//            optionsBuilder.UseSqlServer(connectionString);

//            return new AppDbContext(optionsBuilder.Options);
//        }
//    }
//}
