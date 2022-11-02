using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JollyHeisenberg
{
    public class Helper //contain objects
    {
        protected IWebDriver driver;
        private string baseURL = "https://jolly-heisenberg-fc17f2.netlify.app/";


        private SignIn login;
        private MainPage main;
        private ItemPage item;
        private CartPage cart;
        private PersonalInfo personalInfo;
        private PaymentMethod payment;
        
        public Helper(IWebDriver driver){
            this.driver = driver;           
            this.login = new SignIn(driver);
            this.main = new MainPage(driver);
            this.item = new ItemPage(driver);
            this.cart = new CartPage(driver);
            this.personalInfo = new PersonalInfo(driver);
            this.payment = new PaymentMethod(driver);
        }

        public SignIn Auth {
            get {
                return login;
            }
        }
        public MainPage Main
        {
            get
            {
                return main;
            }
        }

        public ItemPage Item
        {
            get
            {
                return item;
            }
        }

        public  CartPage Cart
        {
            get
            {
                return cart;
            }
        }

        public PersonalInfo Personal
        {
            get
            {
                return personalInfo;
            }
        }
        public PaymentMethod Payment
        {
            get
            {
                return payment;
            }
        }

       
    }
}
