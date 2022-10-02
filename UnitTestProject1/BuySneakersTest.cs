using System;
using System.Collections.Generic;
using System.Linq;
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
    public class OnlineShop
    {
        private IWebDriver driver;
        private string baseURL = "https://jolly-heisenberg-fc17f2.netlify.app/";



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

       /* [Test]
        public void BuySneakers()
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
            PersonalData personalData = new PersonalData();
            PayData pay = new PayData();
            help.Personal.PersonalPayInfo(personalData.Name, personalData.Surname, personalData.Address, personalData.Phone);
            help.Payment.PaymentInfo(pay.Number, pay.Name, pay.Date, pay.CVV);
            Thread.Sleep(1000);
            StoreDataBase db = new StoreDataBase();
            List<PayData>fromdb=(from g in db.Pays select g).ToList();
            db.Close();
        }*/

        [Test]
        public void CheckCart()
        {
            Helper help = new Helper(driver);
            help.Auth.Login("test@test.ru", "Qwerty123");
            Thread.Sleep(600);
            help.Main.SelectRedSneaker();
            Thread.Sleep(600);
            help.Item.AddToCart();
            string itemName = help.Item.GetItemName();
            Thread.Sleep(600);
            help.Main.GoToCart();
            Thread.Sleep(600);
            string cartItemName=help.Cart.CartItemName();
            Assert.AreEqual(itemName,cartItemName);
        }
        [Test]
        public void IncorrectLogin()
        {
        Helper help = new Helper(driver);
        help.Auth.Login(" ", " ");
        Thread.Sleep(600);
        string currentUrl= driver.Url;
        Assert.AreNotEqual(currentUrl, baseURL);
        }
    }
}
