using Alura.LeilaoOnline.Selenium.Helpers;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using System;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    public class AoNavegarParaHomeMobile : IDisposable
    {
        private ChromeDriver driver;

        public AoNavegarParaHomeMobile()
        {           
        }

        [Fact]
        public void DadaLargura992DeveMostrarMobile()
        {
            //arrange
            var deviceSettings = new ChromiumMobileEmulationDeviceSettings();
            deviceSettings.Width = 992;
            deviceSettings.Height = 800;
            deviceSettings.UserAgent = "Customizada";
            var options = new ChromeOptions();
            options.EnableMobileEmulation(deviceSettings);
            driver = new ChromeDriver(TestHelper.PastaDoExecutavel, options);
            var homePO = new HomeNaoLogadaPO(driver);
            //act
            homePO.Visitar();
            //assert
            Assert.True(homePO.Menu.MenuMobileVisivel);
        }

        [Fact]
        public void DadaLargura993NaoDeveMostrarMobile()
        {
            //arrange
            var deviceSettings = new ChromiumMobileEmulationDeviceSettings();
            deviceSettings.Width = 993;
            deviceSettings.Height = 800;
            deviceSettings.UserAgent = "Customizada";
            var options = new ChromeOptions();
            options.EnableMobileEmulation(deviceSettings);
            driver = new ChromeDriver(TestHelper.PastaDoExecutavel, options);
            var homePO = new HomeNaoLogadaPO(driver);
            //act
            homePO.Visitar();
            //assert
            Assert.False(homePO.Menu.MenuMobileVisivel);
        }


        public void Dispose()
        {
            driver.Quit();
        }
    }
}
