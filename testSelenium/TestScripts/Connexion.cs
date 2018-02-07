using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace testSelenium
{
	[TestFixture]
    public class Connexion
	{
		private ISelenium selenium;
		private StringBuilder verificationErrors;
		
		public Connexion(ISelenium _selenium)
		{
			selenium = _selenium;

		}

        //[SetUp]
        //public void SetupTest(string nav)
        //{
        //if (selenium == null)
        //{
        //    selenium = new DefaultSelenium("localhost", 4444, "*" + nav, "http://localhost:9080");
        //}
        //    selenium.Start();
        //    verificationErrors = new StringBuilder();
        //}
		
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
		
		[Test]
        public void TheConnexionTest(string idUser, string pass)
		{
			selenium.Open("/KARA_WEB/deconnexion.do");
            selenium.Type("idUtilisateur", idUser);
            selenium.Type("motDePasse", pass);
			selenium.Click("B1");
			selenium.WaitForPageToLoad("30000");
            selenium.GetAlert();
		}
        
	}
}
