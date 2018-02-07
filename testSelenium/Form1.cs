using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Tamir.SharpSsh;

namespace testSelenium
{
    public partial class Form1 : Form
    {

        // Objets Selenium
        //private testSelenium.test_seleniumCS selTest = new testSelenium.test_seleniumCS();
        //private testSelenium.Connexion testConnexion = new testSelenium.Connexion();

        // Objet Telnet

        // Constantes
        private const string ADDRESS_SERVEUR_TELNET = "172.16.0.67";
        private const int PORT_SERVEUR_TELNET = 22;
        private const string LOGIN_SERVEUR_TELNET = "vsdev1";
        private const string PASSWD_SERVEUR_TELNET = "vsdev1";
        private const string ROOT_LOG_SERVEUR_TELNET = "gsoap/log/";

        private const string NAVIGATEUR = testSelenium.Constantes.Navigateur.IE;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                selTest.TheTest_seleniumCSTest("0088195");
                selTest.TheTest_seleniumCSTest("0088197");
            }
            catch (Selenium.SeleniumException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                selTest.TeardownTest();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SshExec shell = new SshExec(ADDRESS_SERVEUR_TELNET, LOGIN_SERVEUR_TELNET, PASSWD_SERVEUR_TELNET);

                ShellBox.AppendText("Connecting...\n");

                shell.Connect();

                if (shell.Connected == true)
                {
                    ShellBox.AppendText("Connexion OK\n");

                    //while (true)
                    //{
                    System.Threading.Thread.Sleep(500);
                    string output = shell.RunCommand(@"tail -f \gsoap\log\VSSrvConnexionGS.log");
                    ShellBox.AppendText(output + "\n");
                    //}
                    ShellBox.AppendText("Disconnecting...\n");
                    shell.Close();
                    if (shell.Connected == false)
                    {
                        ShellBox.AppendText("Deconnexion OK\n");
                    }
                    else
                    {
                        ShellBox.AppendText("Deconnexion KO\n");
                    }
                }
                else
                {
                    ShellBox.AppendText("Connexion KO\n");
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Test sur la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string resTest = string.Empty;

            try
            {
                testConnexion.SetupTest(NAVIGATEUR);
            }
            catch (Selenium.SeleniumException exc)
            {
                MessageBox.Show(exc.Message);
            }

            // Test OK
            try
            {
                //testConnexion.myTest(new object[] { "0088195", "2697" });

                Application.DoEvents();

                richTextBox2.AppendText("Test Connexion 1 OK\t " + resTest + "\n");
            }
            catch (Selenium.SeleniumException exc)
            {
                MessageBox.Show(exc.Message);
                richTextBox2.Text = richTextBox2.Text + "Test Connexion 1 K0\n";
            }

            //// Test KO -> mauvais login
            //try
            //{
            //    resTest = testConnexion.myTest("0088197", "2697");

            //    Application.DoEvents();

            //    richTextBox2.AppendText("Test Connexion 2 OK\t " + resTest + "\n");
            //}
            //catch (Selenium.SeleniumException exc)
            //{
            //    MessageBox.Show(exc.Message);
            //    richTextBox2.Text = richTextBox2.Text + "Test Connexion 2 K0\n";
            //}

            //// Test KO -> mauvais mdp
            //try
            //{
            //    resTest = testConnexion.myTest("0088195", "2698");

            //    Application.DoEvents();

            //    richTextBox2.AppendText("Test Connexion 3 OK\t " + resTest + "\n");
            //}
            //catch (Selenium.SeleniumException exc)
            //{
            //    MessageBox.Show(exc.Message);
            //    richTextBox2.Text = richTextBox2.Text + "Test Connexion 3 KO\n";
            //}

            testConnexion.TeardownTest();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}