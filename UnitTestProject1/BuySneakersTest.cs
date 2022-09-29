using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace JollyHeisenberg

{
    
    [TestFixture]
    public class BuySneakersTest
    {
        private IWebDriver driver;
        private string baseURL= "https://jolly-heisenberg-fc17f2.netlify.app/";
        


        [TestFixtureSetUp]
        public void SetupTest()
        {
                 
            driver = new ChromeDriver();
            driver.Url = baseURL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            

        }

        [TestFixtureTearDown]
        public void TeardownTest()
        {
                driver.Quit();            
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            Helper help = new Helper(driver);
            help.Auth.Login("test@test.ru", "Qwerty123");            
            Thread.Sleep(600);
            help.Main.SelectRedSneaker();           
            Thread.Sleep(600);
            help.Item.AddToCart();
            Thread.Sleep(600);
            help.Main.GoToCart();            
            Thread.Sleep(600);
            help.Cart.FromCartToPay();            
            Thread.Sleep(600);
            Data data = new Data();
            help.Personal.PersonalPayInfo(data.Name, data.Surname, data.Address, data.Phone);
            help.Payment.PaymentInfo(data.Number,data.Name,data.Date,data.CVV);
            Thread.Sleep(1000);
        }

        

    

        

        

        

       

        
    }
}
