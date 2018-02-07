using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace testSelenium.Classes
{
    class Selenium
    {
        public ISelenium selenium ;
        private StringBuilder verificationErrors;

        [SetUp]
        public void SetupTest(string nav)
        {
            selenium = new DefaultSelenium("localhost", 4444, "*" + nav, "http://localhost:9080");

            selenium.Start();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                selenium.Stop();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
    }
}
