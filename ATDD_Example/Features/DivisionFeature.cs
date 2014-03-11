using System.Diagnostics;
using System.IO;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ATDD_Example.Features
{
    [TestFixture]
    public class DivisionFeature
    {
        
        [Test]
        public void When_open_calculator()
        {
            StartWebSite();

            var webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://localhost:9999/index.html");

            var firstNumber = webDriver.FindElement(By.Id("FirstNumberDivide")).GetAttribute("value");
            var secondNumber = webDriver.FindElement(By.Id("SecondNumberDivide")).GetAttribute("value");
            var answer = webDriver.FindElement(By.Id("DivideAnswer")).Text;


            Assert.That(firstNumber, Is.EqualTo(""));
            Assert.That(secondNumber, Is.EqualTo(""));
            Assert.That(answer, Is.EqualTo("="));
        }

        [Test]
        public void When_divide_35_by_7()
        {
            /*
             * first number enter 35
             * second number enter 7
             * click divide
             * answer should be 5
             * and first number should be ""
             * and second number should be ""
             */

            StartWebSite();

            var webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://localhost:9999/index.html");

            webDriver.FindElement(By.Id("FirstNumberDivide")).SendKeys("35");
            webDriver.FindElement(By.Id("SecondNumberDivide")).SendKeys("7");
            
            webDriver.FindElement(By.Id("DivideButton")).Click();
            
            var answer = webDriver.FindElement(By.Id("DivideAnswer")).Text;
            var firstNumber = webDriver.FindElement(By.Id("FirstNumberDivide")).GetAttribute("value");
            var secondNumber = webDriver.FindElement(By.Id("SecondNumberDivide")).GetAttribute("value");
            var firstNumberHasFocus = ((IJavaScriptExecutor)webDriver)
            Assert.That(answer, Is.EqualTo("5"));
            Assert.That(firstNumber, Is.EqualTo(""));
            Assert.That(secondNumber, Is.EqualTo(""));
            
            Assert.That(firstNumberHasFocus, Is.True);
        }

        [Test]
        public void When_divide_35_by_0()
        {
            Assert.Inconclusive("todo");
        }
        
        [Test]
        public void When_divide_1_by_3()
        {
            Assert.Inconclusive("todo");
        }
        
        [Test]
        public void When_divide_minus_35_by_minus_7()
        {
            Assert.Inconclusive("todo");
        }

        [Test]
        public void When_divide_minus_35_by_7()
        {
            Assert.Inconclusive("todo");
        }

        private void StartWebSite()
        {
            KillWebServer();
            KillChromeDriver();
            StartWebServer();
        }

        private void KillChromeDriver()
        {
            KillProcess("chromedriver");
        }

        private static string WebServer { get { return Path.Combine(System.Environment.CurrentDirectory, "mongoose-free-5.2.exe"); } }
        private static string WebSite { get { return @"C:\Projects\ATDD_Example\Calculator.Web"; } }
        
        private static void KillWebServer()
        {
            var webServerFilename = Path.GetFileNameWithoutExtension(WebServer);
            KillProcess(webServerFilename);
        }

        private static void KillProcess(string webServerFilename)
        {
            var webServers = Process.GetProcessesByName(webServerFilename);
            foreach (var process in webServers)
            {
                process.Kill();
            }
        }

        private static void StartWebServer()
        {
            var webServerArgs = string.Format(
                "-document_root \"{0}\" -listening_port {1}",
                WebSite,
                9999);

            Process.Start(WebServer, webServerArgs);
        }
    }
}
