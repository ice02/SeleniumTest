using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace testSelenium
{
	[TestFixture]
	public class Test01
	{
		private ISelenium selenium;
		private StringBuilder verificationErrors;

        public Test01(ISelenium _selenium)
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
		public void TheTest01Test(string login)
		{
			selenium.Open("/KARA_WEB/deconnexion.do");
			selenium.Type("idUtilisateur", "0088195");
			selenium.Type("motDePasse", "2697");
			selenium.Click("B1");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("bt_3_0");
			selenium.WaitForPageToLoad("30000");
			selenium.Select("codeGestion", "label=Migration Forfaits Bloqués vers Abo - Ajout");
			selenium.Type("numAppelAjt", "0640684010");
			selenium.Type("numICCIDAjt", "89331072970067505032");
			selenium.Click("B2");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("//img[@onclick='valider()']");
			selenium.WaitForPageToLoad("30000");
			selenium.Type("numTitAjt", "100001");
			selenium.Type("numCtrAjt", "000001");
			selenium.Type("numPtFactAjt", "03");
			selenium.Click("B2");
			selenium.WaitForPageToLoad("30000");
			selenium.Select("choixUtilisateur", "label=Utilisateur = pt facturation");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("B2");
			selenium.WaitForPageToLoad("30000");
			selenium.Select("choixOffre", "label=Nouvelle offre");
			selenium.WaitForPageToLoad("30000");
			selenium.Select("choixCible", "label=Gamme SFR Evolution Pro");
			selenium.Click("B2");
			selenium.WaitForPageToLoad("30000");
			selenium.Select("champ_1", "label=SFR Evolution Pro 3H");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("btnsuiv");
			selenium.WaitForPageToLoad("30000");
			Assert.AreEqual("V&S KARA - Les Offres", selenium.GetTitle());
			selenium.Click("btnsuiv");
			selenium.WaitForPageToLoad("30000");
			selenium.Click("btnsuiv");
			selenium.WaitForPageToLoad("30000");
			selenium.Select("champ_1", "label=Liste Rouge");
			selenium.Select("champ_12", "label=Controle Parental Inactif");
			selenium.Click("btnsuiv");
			selenium.WaitForPageToLoad("30000");
			selenium.Type("champ_2", "");
			selenium.Click("B2");
			selenium.Type("champ_2", "8");
		}
	}
}
