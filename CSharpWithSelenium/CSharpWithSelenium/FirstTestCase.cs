using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpWithSelenium
{
    internal class FirstTestCase
    {
        static void Main(string[] args)
        {

            //This Example just open a Website on Chrome
            //Ernesto Gonzalez Olaez
            IWebDriver driver=new ChromeDriver();
            driver.Url="https://demoqa.com/";
            
        }
    }
}
