using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Bogus;
using System.Collections.Generic;

namespace JollyHeisenberg
{
    public class PaymentMethod //Fill payment info - step 6
    {
        private IWebDriver driver;
        public PaymentMethod(IWebDriver driver)
        {
            this.driver = driver;
        }
       

        
        public List<string> PaymentInfo(string number, string name, string date, string cvv)
        {
            this.NewPaymentMethod();
            Number = number;
            this.InputNumber(Number);
            Name = name;
            this.InputName(Name);
            Date = date;
            this.InputDate(Date);
            CVV = cvv;
            this.InputCVV(CVV);
            this.Click();
            List<string> uidata = new List<string>();
            uidata.Add(Number);
            uidata.Add(Name);
            uidata.Add(Date);
            uidata.Add(CVV);
            return uidata;
        }

        
        public string Number { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string CVV { get; set; }
        private void Click()
        {
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
        }

        private void NewPaymentMethod()
        {
            driver.FindElement(By.XPath("//div[@id='__layout']/div/div/div/div/div/div/div")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Новая карта')]")).Click();
        }

        private void InputNumber(string number) {
            
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div[1]/div[1]/input")).SendKeys(number);
        }

        private void InputName(string name) {
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div[1]/div[3]/input")).SendKeys(name);
        }

        private void InputDate(string date) {
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/input")).SendKeys(date);        
        }

        private void InputCVV(string cvv) {
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div[2]/div/div[2]/div/div/input")).SendKeys(cvv);
        }

    }
}
