using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_Project
{
    public class TestBaseDriver
    {
        public IWebDriver _driver = new ChromeDriver(@"C:\Users\Ryan\Desktop\Drivers");
    }
}
