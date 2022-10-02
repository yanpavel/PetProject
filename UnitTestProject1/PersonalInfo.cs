using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Bogus;

namespace JollyHeisenberg
{
    public class PersonalInfo //Fill personal info - step 5
    {
        private IWebDriver driver;
        public PersonalInfo(IWebDriver driver)
        {
            this.driver = driver;
        }
        

        public void PersonalPayInfo(string name, string surname, string address, string phone)
        {
            this.FillName(name);
            this.FillSurname(surname);
            this.FillAddress(address);
            this.FillPhone(phone);
            this.Click();
            
        }

        private void Click()
        {
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
        }

        private PersonalInfo FillPhone(string phone)
        {
            driver.FindElement(By.Name("phone")).SendKeys(phone);
            return this;
        }

        private PersonalInfo FillAddress(string address)
        {
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys(address);
            return this;
        }

        private PersonalInfo FillSurname(string surname)
        {
            
            driver.FindElement(By.XPath("//div[@id='__layout']/div/div/div/form/div/div/div[2]/input")).SendKeys(surname);
            return this;
        }

        private PersonalInfo FillName(string name)
        {
            driver.FindElement(By.XPath("//div[@id='__layout']/div/div/div/form/div/div/div/input")).SendKeys(name);
            return this;
        }
    }
}
