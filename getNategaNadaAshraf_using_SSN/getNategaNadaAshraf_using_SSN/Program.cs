using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace getNategaNadaAshraf_using_birthdate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Window w = new Window();
            Application.Run(w);

            new seleniumRun(w.SSN);


        }

    }
    public class seleniumRun
    {
        IWebDriver driver;

        public seleniumRun(double id)
        {
            driver=new ChromeDriver();
            //driver=new OperaDriver();
            //driver=new FirefoxDriver();
// driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tdb.tanta.edu.eg/eng_voting/default.aspx");
            
            driver.FindElement(By.Id("txt_ssid")).SendKeys(id.ToString());
            for (int i = 0; i < 3000; i++)
            {
                driver.FindElement(By.Id("txt_ssid")).Clear();
                driver.FindElement(By.Id("txt_ssid")).SendKeys(id.ToString());
                id++;
                driver.FindElement(By.Id("Button2")).Click();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(.65);


                if(driver.FindElement(By.Id("lblSecurityCode")).Text!= "الرقم القومي الذي قمت بإدخاله غير صحيح")
                {
                    break;
                }
                Console.WriteLine("congratulation");
                driver.Close();
                //var d=driver.PageSource;
                
            }

        }

    }
}