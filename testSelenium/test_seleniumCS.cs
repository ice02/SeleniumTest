using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace testSelenium
{
	[TestFixture]
	public class test_seleniumCS
	{
		private ISelenium selenium;
		private StringBuilder verificationErrors;
		
		[SetUp]
		public void SetupTest()
		{
            try
            {
                selenium = new DefaultSelenium("localhost", 4444, "*firefox", "http://localhost:9080/");
                selenium.Start();
                verificationErrors = new StringBuilder();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message) ;
            }
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
		
		[Test]
		public void TheTest_seleniumCSTest(string idUser)
		{
			selenium.Open("/KARA_WEB/deconnexion.do");
			selenium.Type("idUtilisateur", idUser);
			selenium.Type("motDePasse", "2697");
			selenium.Click("B1");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("bt_4_0");
			selenium.WaitForPageToLoad("30000");
			selenium.Type("dateNaissJ", "21");
			selenium.Type("dateNaissM", "04");
			selenium.Type("dateNaissA", "1987");
			selenium.Type("nom", "SINCLAR");
			selenium.Type("prenom", "BOB");
			selenium.Click("//img[@onclick='ChangerOnglet(2)']");
			selenium.Type("numVoie", "ICI");
			selenium.Type("codePostal", "32456");
			selenium.Type("burDistr", "ICI");
			selenium.Click("//img[@onclick='ChangerOnglet(3)']");
			selenium.Type("numICCID", "89331059970000209012");
			selenium.Type("numIMEI", "111111111111119");
			selenium.Click("B2");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("//img[@onclick='valider()']");
			selenium.WaitForPageToLoad("30000");
		}
	}
}
