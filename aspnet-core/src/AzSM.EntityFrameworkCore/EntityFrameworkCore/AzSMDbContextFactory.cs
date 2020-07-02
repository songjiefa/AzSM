using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AzSM.Configuration;
using AzSM.Web;

namespace AzSM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AzSMDbContextFactory : IDesignTimeDbContextFactory<AzSMDbContext>
    {
        public AzSMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AzSMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AzSMDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AzSMConsts.ConnectionStringName));

            return new AzSMDbContext(builder.Options);
        }
    }
}
