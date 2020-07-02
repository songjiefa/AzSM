using System.Threading.Tasks;
using AzSM.Models.TokenAuth;
using AzSM.Web.Controllers;
using Shouldly;
using Xunit;

namespace AzSM.Web.Tests.Controllers
{
    public class HomeController_Tests: AzSMWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}