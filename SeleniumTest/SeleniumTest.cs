using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;


namespace Lab_Excer
{
    [TestClass]
    public class SeleniumTest
    {
        /*
        [DataTestMethod]
        [DataRow ("FF","https://www.demoblaze.com/")]
        [DataRow ("CH","https://www.demoblaze.com/")]
        [DataRow ("CH","https://www.demoblaze.com/")]

        
        
        public void LaunchBrowser(string browsername,string url)
        {
            IWebDriver driver;
            if(browsername=="FF")
            {
                driver=new FirefoxDriver();
            }
            else if(browsername=="CH")
            {
                driver=new ChromeDriver();
            }
            else
            {
                driver = new EdgeDriver();
            }
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(5000);
            driver.Quit();
        } */
        

        /*
        [TestMethod]
        
        public void TestMethod()
        {
            IWebDriver driver =new ChromeDriver();
            driver.Navigate().GoToUrl("https://automationpractice.com/");
            IWebElement Contactus=driver.FindElement(By.Id("Contact_Link"));
            Contactus.Click();
            Thread.Sleep(5000);
            driver.Quit();
        } 

        [TestMethod]
        
        public void TestMethod1()
        {
            IWebDriver driver =new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            IWebElement Contact=driver.FindElement(By.LinkText("Contact"));
            Contact.Click();
            Thread.Sleep(8000);
            driver.Quit();
        } */

        
        [DataTestMethod]
        [DataRow ("FF","abc@gmail.com","abc","welcome")]
        [DataRow ("CH","xyz@gmail.com","xyz","hai")]
        [DataRow ("ED","ghi@gmail.com","ghi","hello")]

        
        
        public void LaunchBrowser(string browsername,string op1,string op2,string op3)
        {
            IWebDriver driver;
            if(browsername=="FF")
            {
                driver=new FirefoxDriver();
            }
            else if(browsername=="CH")
            {
                driver=new ChromeDriver();
            }
            else
            {
                driver = new EdgeDriver();
            }
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            IWebElement Contact=driver.FindElement(By.LinkText("Contact"));
            Contact.Click();
             Thread.Sleep(8000);

            IWebElement ContactEmail=driver.FindElement(By.Id("recipient-email"));
            ContactEmail.SendKeys(op1);
            Thread.Sleep(2000);

            IWebElement ContactName=driver.FindElement(By.Id("recipient-name"));
            ContactName.SendKeys(op2);
            Thread.Sleep(2000);

            IWebElement Message=driver.FindElement(By.Id("message-text"));
            Message.SendKeys(op3);
            Thread.Sleep(2000);

            IWebElement Close=driver.FindElement(By.XPath("//button[text()='Send message']//preceding-sibling::button[text()='Close']"));
            Close.Click();
            Thread.Sleep(5000);


            driver.Quit();
        }
        
    
        
    }
}