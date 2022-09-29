using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JollyHeisenberg
{
    public class SignIn //LoginPage flow-step 1
    {
        private IWebDriver driver;

        public SignIn(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Login(string _login, string _password)
        {
            //this.StartPage();
            this.LoginPassword(_login, _password);
            this.LoginButton();
        }

        public void LoginButton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        public void LoginPassword(string login, string password)
        {
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(login);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);           
        }

        /*public void StartPage()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='__layout']/div/div/div/button")).Click();                
            }
            catch (NoSuchElementException)
            {
                driver.Navigate().GoToUrl("https://jolly-heisenberg-fc17f2.netlify.app");               
            }
            
            
            
        }*/


    }
}
