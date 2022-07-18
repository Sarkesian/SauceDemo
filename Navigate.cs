using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_Project
{
    public class Navigate
    {
        public void CNavigate (IWebDriver driver, String URL) 
        {
            driver.Url = (URL);
        }
    }
}
