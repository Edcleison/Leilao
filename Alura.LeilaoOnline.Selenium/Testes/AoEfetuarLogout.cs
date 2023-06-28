using Xunit;
using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoEfetuarLogout
    {
        //private IWebDriver driver;

        private IWebDriver driver;

        public AoEfetuarLogout(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoLoginValidoDeveIrParaHomeNaoLogada()
        {
            //arrange
            new LoginPO(driver).Visitar().InformarEmail("fulano@example.org").InformarSenha( "123").EfetuarLogin();
                //.EfetuarLoginComCredeciais("fulano@example.org", "123");

            var dashboardPO = new DashboardInteressadaPO(driver);

            //act - efetuar logout
            dashboardPO.MenuLogado.EfetuarLogout();

            //assert
            Assert.Contains("Próximos Leilões", driver.PageSource);

        }
    }
}
