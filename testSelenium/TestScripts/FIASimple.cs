using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace testSelenium
{
	[TestFixture]
	public class FIASimple
	{
		private ISelenium selenium;
		private StringBuilder verificationErrors;
		
		public FIASimple(ISelenium _selenium)
		{
			selenium = _selenium;
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
        public void TheFIASimpleTest(string dateNaissJ, string dateNaissM, string dateNaissA,
            string nom, string prenom, string numVoie, string codePostal, string burDistr,
            string numICCID, string numIMEI)
        {
            selenium.Click("bt_4_0");
            selenium.WaitForPageToLoad("30000");
            selenium.Type("dateNaissJ", dateNaissJ);
            selenium.Type("dateNaissM", dateNaissM);
            selenium.Type("dateNaissA", dateNaissA);
            selenium.Click("document.fiaForm.codeDptNaiss[1]");
            selenium.Select("document.fiaForm.codeDptNaiss[1]", "label=ALLIER");
            selenium.Click("//option[@value='03']");
            selenium.Select("civilite", "label=Madame");
            selenium.Type("nom", nom);
            selenium.Type("prenom", prenom);
            selenium.Click("//img[@onclick='ChangerOnglet(2)']");
            selenium.Type("numVoie", numVoie);
            selenium.Type("codePostal", codePostal);
            selenium.Type("burDistr", burDistr);
            selenium.Click("//img[@onclick='ChangerOnglet(3)']");
            selenium.Type("numICCID", numICCID);
            selenium.Type("numIMEI", numIMEI);
            selenium.Click("B2");
            selenium.WaitForPageToLoad("30000");
            selenium.Click("//img[@onclick='valider()']");
            selenium.WaitForPageToLoad("30000");
		}
	}
}
