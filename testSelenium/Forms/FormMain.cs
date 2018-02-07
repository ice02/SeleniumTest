using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using System.Net.Sockets;

using System.IO;

using testSelenium.Composants;

namespace testSelenium.Forms
{
    public partial class FormMain : Form
    {
        private DataSet dataSetMain = null;
        private string navigateur = string.Empty;

        // Objet Selenium
        Classes.Selenium objSelenium = new testSelenium.Classes.Selenium();

        // Objet utilisé pour la reflexion de type
        private Type actionType = null;
        private Object test = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // tab tests unitaires
                if (tabControlMain.SelectedIndex == 0)
                {
                    listBoxActions.Items.Clear();

                    foreach (DataTable elem in dataSetMain.Tables)
                    {
                        listBoxActions.Items.Add(elem.TableName);
                    }
                }
                // tab gestion des TU
                if (tabControlMain.SelectedIndex == 1)
                {
                    listBoxActionXML.Items.Clear();

                    foreach (DataTable elem in dataSetMain.Tables)
                    {
                        listBoxActionXML.Items.Add(elem.TableName);
                    }
                }
                // tab scenarios de tests
                if (tabControlMain.SelectedIndex == 2)
                {
                }
                // tab options
                if (tabControlMain.SelectedIndex == 3)
                {
                    listBoxOption.Items.Clear();

                    foreach (DataTable elem in dataSetMain.Tables)
                    {
                        listBoxOption.Items.Add(elem.TableName);
                    }
                }
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        #region Onglet Options

        /// <summary>
        /// Bouton ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string nomAction = string.Empty;
            string lstParams = string.Empty;

            try
            {
                if (Directory.Exists(Application.StartupPath + @"..\..\TestScripts"))
                {
                    openFileDialogMain.InitialDirectory = Application.StartupPath + @"..\..\TestScripts";
                }
                if (openFileDialogMain.ShowDialog() == DialogResult.OK)
                {
                    FileInfo infos = new FileInfo(openFileDialogMain.FileName);
                    nomAction = infos.Name.Replace(infos.Extension, "");
                    if (listBoxOption.Items.Contains(nomAction) == false)
                    {
                        string subElem = string.Empty;

                        listBoxOption.Items.Add(nomAction);
                        // Parser le fichier source, trouver la fonction de test et recuperer les parametres
                        String src = File.ReadAllText(openFileDialogMain.FileName);
                        lstParams = Classes.StringParser.getParams(src, nomAction);
                        // Traitement des parametres
                        dataSetMain.Tables.Add(nomAction);
                        foreach (string elem in lstParams.Split(','))
                        {
                            subElem = elem.Trim().Split(' ')[1];
                            dataSetMain.Tables[nomAction].Columns.Add(subElem.Trim());
                        }

                        dataSetMain.WriteXml(Application.StartupPath + @"\XML\KaraTests.xml");
                        dataSetMain.WriteXmlSchema(Application.StartupPath + @"\XML\KaraTests.xsd");
                    }
                }
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        //TODO mega bug -> plus implementé pour le moment
        private void buttonOptionModifier_Click(object sender, EventArgs e)
        {
            string nomAction = string.Empty;

            if (listBoxOption.SelectedIndex != -1)
            {
                if ((nomAction = frmInput.InputBox("Modifier le nom d'une Action de test", 
                                                    "Nom du l'action : ", 
                                                    (string)listBoxOption.Items[listBoxOption.SelectedIndex])) 
                    != (string)listBoxOption.Items[listBoxOption.SelectedIndex])
                {
                    // TOREDO
                }
            }
        }

        private void buttonActionSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxOption.SelectedIndex != -1)
                {
                    if (MessageBox.Show("Etes vous sur de vouloir supprimer cette action ?", "VS Tests", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Supprimer le fichier XML et l'entree de la liste
                        if (dataSetMain.Tables.Contains(listBoxOption.Items[listBoxOption.SelectedIndex].ToString()))
                        {
                            dataSetMain.Tables.Remove(listBoxOption.Items[listBoxOption.SelectedIndex].ToString());
                            listBoxOption.Items.RemoveAt(listBoxOption.SelectedIndex);
                            dataSetMain.WriteXml(Application.StartupPath + @"\XML\KaraTests.xml");
                            dataSetMain.WriteXmlSchema(Application.StartupPath + @"\XML\KaraTests.xsd");
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        #endregion

        #region Onglet XML
        private void listBoxActionXML_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxActionXML.SelectedIndex != -1)
            {
                dataGridViewXML.DataSource = dataSetMain.Tables[listBoxActionXML.Items[listBoxActionXML.SelectedIndex].ToString()];
            }
        }
        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Creation du dataset et chargement structure et donnees
            try
            {
                dataSetMain = new DataSet("KaraTests");
                if (File.Exists(Application.StartupPath + @"\XML\KaraTests.xsd"))
                    dataSetMain.ReadXmlSchema(Application.StartupPath + @"\XML\KaraTests.xsd");
                if (File.Exists(Application.StartupPath + @"\XML\KaraTests.xml"))
                    dataSetMain.ReadXml(Application.StartupPath + @"\XML\KaraTests.xml");
                // Chargement du premier ecran
                listBoxActions.Items.Clear();

                foreach (DataTable elem in dataSetMain.Tables)
                {
                    listBoxActions.Items.Add(elem.TableName);
                }

                if (radioButtonFirefox.Checked == true)
                {
                    navigateur = Constantes.Navigateur.FIREFOX;
                }
                else
                {
                    navigateur = Constantes.Navigateur.IE;
                }
                splitContainerTests.Panel2Collapsed = true; ;
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        public void errMess(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataSetMain.WriteXml(Application.StartupPath + @"\XML\KaraTests.xml");
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        private string formatteLigne(DataRow row, DataColumnCollection cols)
        {
            string strTemp = string.Empty;
            int i = 0;

            foreach (object col in row.ItemArray)
            {
                strTemp = strTemp + cols[i].Caption + " :" + col.ToString() + " , ";
                i++;
            }

            return strTemp;
        }

        private void chargeTests(string action)
        {
            try
            {
                checkedListBoxTests.Items.Clear();
                foreach (DataRow row in dataSetMain.Tables[action].Rows)
                {
                    checkedListBoxTests.Items.Add(formatteLigne(row, dataSetMain.Tables[action].Columns));
                }
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        private void listBoxActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedIndex != -1)
            {
                buttonLaunchTests.Enabled = true;
                chargeTests(listBoxActions.Items[listBoxActions.SelectedIndex].ToString());
            }
            else
            {
                buttonLaunchTests.Enabled = false;
            }
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            // The execution of scenarios
            try
            {
                //// Renvoi le type selectionné, exception si le type n'existe pas
                actionType = Type.GetType("testSelenium." + listBoxActions.Items[listBoxActions.SelectedIndex].ToString(), true);
                //// Creation d'un objet contenant l'implementation de notre classe
                object[] args = new object[1];
                args[0] = objSelenium.selenium;
                test = Activator.CreateInstance(actionType, args);

                foreach (int indice in checkedListBoxTests.CheckedIndices)
                {
                    // Recuperer le nombre de param de la fonction de test qui vas etre appellee
                    int nbColonnes = dataSetMain.Tables[listBoxActions.SelectedIndex].Columns.Count;

                    object[] parameters = new Object[nbColonnes];
                    for (int i = 0; i < nbColonnes; i++)
                    {
                        parameters[i] = dataSetMain.Tables[listBoxActions.SelectedIndex].Rows[indice][i].ToString();
                    }

                    // Appeller la fonction de test
                    getMaMethode(listBoxActions.Items[listBoxActions.SelectedIndex].ToString(), 
                                 "The" + listBoxActions.Items[listBoxActions.SelectedIndex].ToString() + "Test").Invoke(
                        test, parameters);
               }
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        MethodInfo getMaMethode(string nomClasse, string nomMethode)
        {
            //// Renvoi le type selectionné, exception si le type n'existe pas
            //Type actionType = Type.GetType("testSelenium." + nomClasse, true);
            //// Creation d'un objet contenant l'implementation de notre classe
            //Object test = Activator.CreateInstance(actionType);

            MethodInfo maMethode = null;

            try
            {
                if (actionType != null)
                {
                    MemberInfo[] MyMemberInfoArray = actionType.GetMembers();

                    //Type[] paramTypes = new Type[1];
                    //paramTypes[0] = typeof(string);
                    maMethode = actionType.GetMethod(nomMethode);//, paramTypes);
                }
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }

            return maMethode;
        }

        /// <summary>
        /// Initialise le portail de test et rend les autres fonctions dispo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLaunchTests_Click(object sender, EventArgs e)
        {
            try
            {
                // recupere le type de navigateur
                if (radioButtonFirefox.Checked == true)
                {
                    navigateur = Constantes.Navigateur.FIREFOX;
                }
                else
                {
                    navigateur = Constantes.Navigateur.IE;
                }

                // Creation de l'objet selenium
                objSelenium.SetupTest(navigateur);

                //Object[] parameters = new Object[1];
                //parameters[0] = navigateur;

                //getMaMethode(listBoxActions.Items[listBoxActions.SelectedIndex].ToString(), "SetupTest").Invoke(
                //            test, parameters);

                buttonFin.Enabled = true;
                buttonLaunchTests.Enabled = false;
                buttonExec.Enabled = true;
            }
            catch (Exception exc)
            {
                errMess(exc.Message);
            }
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            //getMaMethode(listBoxActions.Items[listBoxActions.SelectedIndex].ToString(), "TeardownTest").Invoke(test, null);
            objSelenium.TeardownTest();

            buttonFin.Enabled = false;
            if (listBoxActions.SelectedIndex != -1)
            {
                buttonLaunchTests.Enabled = true;
            }
            else
            {
                buttonLaunchTests.Enabled = false;
            }
            buttonExec.Enabled = false;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // au cas ou, on ferme systematiquement la fenetre de test
            if (listBoxActions.SelectedIndex != -1)
            {
                //getMaMethode(listBoxActions.Items[listBoxActions.SelectedIndex].ToString(), "TeardownTest").Invoke(test, null);
                objSelenium.TeardownTest();
            }
        }

        private void buttonTCPMon_Click(object sender, EventArgs e)
        {
            splitContainerTests.Panel2Collapsed = !splitContainerTests.Panel2Collapsed;
            if (splitContainerTests.Panel2Collapsed == false)
            {
                buttonTCPMon.Text = "Cacher TCP Mon";
            }
            else
            {
                buttonTCPMon.Text = "Montrer TCP Mon";
            }
        }

        private void buttonTCPMonCreate_Click(object sender, EventArgs e)
        {
            //System.Net.IPAddress adress = new System.Net.IPAddress(textBoxURL.Text.ToCharArray());
            //TcpListener l = new TcpListener(adress, int.Parse(textBoxPortFrom.Text));
            //l.Start();
            //l.AcceptSocket();
            
            MessageBox.Show("Yes");
        }
    }
}