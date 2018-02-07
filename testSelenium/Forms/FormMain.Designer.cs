namespace testSelenium.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.splitContainerTests = new System.Windows.Forms.SplitContainer();
            this.checkedListBoxTests = new System.Windows.Forms.CheckedListBox();
            this.tabControlTCPMon = new System.Windows.Forms.TabControl();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonTCPMonCreate = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPortTo = new System.Windows.Forms.TextBox();
            this.textBoxPortFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMainTests = new System.Windows.Forms.Panel();
            this.buttonTCPMon = new System.Windows.Forms.Button();
            this.buttonLaunchTests = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonIE = new System.Windows.Forms.RadioButton();
            this.radioButtonFirefox = new System.Windows.Forms.RadioButton();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonExec = new System.Windows.Forms.Button();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelXML = new System.Windows.Forms.Panel();
            this.buttonSaveScenar = new System.Windows.Forms.Button();
            this.textBoxDescAction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewXML = new System.Windows.Forms.DataGridView();
            this.listBoxActionXML = new System.Windows.Forms.ListBox();
            this.tabPageScenar = new System.Windows.Forms.TabPage();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.buttonOptionModifier = new System.Windows.Forms.Button();
            this.buttonActionSupprimer = new System.Windows.Forms.Button();
            this.buttonOptionAjouter = new System.Windows.Forms.Button();
            this.listBoxOption = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.splitContainerTests.Panel1.SuspendLayout();
            this.splitContainerTests.Panel2.SuspendLayout();
            this.splitContainerTests.SuspendLayout();
            this.tabControlTCPMon.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.panelMainTests.SuspendLayout();
            this.tabPageXML.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelXML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).BeginInit();
            this.tabPageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTest);
            this.tabControlMain.Controls.Add(this.tabPageXML);
            this.tabControlMain.Controls.Add(this.tabPageScenar);
            this.tabControlMain.Controls.Add(this.tabPageOptions);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(825, 561);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.splitContainerTests);
            this.tabPageTest.Controls.Add(this.panelMainTests);
            this.tabPageTest.Controls.Add(this.listBoxActions);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(817, 535);
            this.tabPageTest.TabIndex = 0;
            this.tabPageTest.Text = "Tests unitaires";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // splitContainerTests
            // 
            this.splitContainerTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTests.Location = new System.Drawing.Point(209, 3);
            this.splitContainerTests.Name = "splitContainerTests";
            this.splitContainerTests.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTests.Panel1
            // 
            this.splitContainerTests.Panel1.Controls.Add(this.checkedListBoxTests);
            // 
            // splitContainerTests.Panel2
            // 
            this.splitContainerTests.Panel2.Controls.Add(this.tabControlTCPMon);
            this.splitContainerTests.Size = new System.Drawing.Size(605, 422);
            this.splitContainerTests.SplitterDistance = 119;
            this.splitContainerTests.TabIndex = 4;
            // 
            // checkedListBoxTests
            // 
            this.checkedListBoxTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxTests.FormattingEnabled = true;
            this.checkedListBoxTests.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxTests.Name = "checkedListBoxTests";
            this.checkedListBoxTests.Size = new System.Drawing.Size(605, 109);
            this.checkedListBoxTests.TabIndex = 5;
            // 
            // tabControlTCPMon
            // 
            this.tabControlTCPMon.Controls.Add(this.tabPageAdmin);
            this.tabControlTCPMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTCPMon.Location = new System.Drawing.Point(0, 0);
            this.tabControlTCPMon.Name = "tabControlTCPMon";
            this.tabControlTCPMon.SelectedIndex = 0;
            this.tabControlTCPMon.Size = new System.Drawing.Size(605, 299);
            this.tabControlTCPMon.TabIndex = 0;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.richTextBox1);
            this.tabPageAdmin.Controls.Add(this.buttonTCPMonCreate);
            this.tabPageAdmin.Controls.Add(this.textBoxURL);
            this.tabPageAdmin.Controls.Add(this.label7);
            this.tabPageAdmin.Controls.Add(this.textBoxPortTo);
            this.tabPageAdmin.Controls.Add(this.textBoxPortFrom);
            this.tabPageAdmin.Controls.Add(this.label6);
            this.tabPageAdmin.Controls.Add(this.label5);
            this.tabPageAdmin.Controls.Add(this.label4);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(597, 273);
            this.tabPageAdmin.TabIndex = 0;
            this.tabPageAdmin.Text = "Administration";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(274, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 232);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // buttonTCPMonCreate
            // 
            this.buttonTCPMonCreate.Location = new System.Drawing.Point(13, 127);
            this.buttonTCPMonCreate.Name = "buttonTCPMonCreate";
            this.buttonTCPMonCreate.Size = new System.Drawing.Size(234, 23);
            this.buttonTCPMonCreate.TabIndex = 7;
            this.buttonTCPMonCreate.Text = "Lancer l\'ecoute";
            this.buttonTCPMonCreate.UseVisualStyleBackColor = true;
            this.buttonTCPMonCreate.Click += new System.EventHandler(this.buttonTCPMonCreate_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(13, 80);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(234, 20);
            this.textBoxURL.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Depuis/vers l\'adresse :";
            // 
            // textBoxPortTo
            // 
            this.textBoxPortTo.Location = new System.Drawing.Point(187, 24);
            this.textBoxPortTo.Name = "textBoxPortTo";
            this.textBoxPortTo.Size = new System.Drawing.Size(60, 20);
            this.textBoxPortTo.TabIndex = 4;
            // 
            // textBoxPortFrom
            // 
            this.textBoxPortFrom.Location = new System.Drawing.Point(66, 24);
            this.textBoxPortFrom.Name = "textBoxPortFrom";
            this.textBoxPortFrom.Size = new System.Drawing.Size(60, 20);
            this.textBoxPortFrom.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "jusqu\'a : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "A partir de : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ports d\'écoute :";
            // 
            // panelMainTests
            // 
            this.panelMainTests.Controls.Add(this.buttonTCPMon);
            this.panelMainTests.Controls.Add(this.buttonLaunchTests);
            this.panelMainTests.Controls.Add(this.label3);
            this.panelMainTests.Controls.Add(this.radioButtonIE);
            this.panelMainTests.Controls.Add(this.radioButtonFirefox);
            this.panelMainTests.Controls.Add(this.buttonFin);
            this.panelMainTests.Controls.Add(this.buttonExec);
            this.panelMainTests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainTests.Location = new System.Drawing.Point(209, 425);
            this.panelMainTests.Name = "panelMainTests";
            this.panelMainTests.Size = new System.Drawing.Size(605, 107);
            this.panelMainTests.TabIndex = 3;
            // 
            // buttonTCPMon
            // 
            this.buttonTCPMon.Location = new System.Drawing.Point(226, 66);
            this.buttonTCPMon.Name = "buttonTCPMon";
            this.buttonTCPMon.Size = new System.Drawing.Size(102, 23);
            this.buttonTCPMon.TabIndex = 8;
            this.buttonTCPMon.Text = "Montrer TCP Mon";
            this.buttonTCPMon.UseVisualStyleBackColor = true;
            this.buttonTCPMon.Click += new System.EventHandler(this.buttonTCPMon_Click);
            // 
            // buttonLaunchTests
            // 
            this.buttonLaunchTests.Enabled = false;
            this.buttonLaunchTests.Location = new System.Drawing.Point(7, 8);
            this.buttonLaunchTests.Name = "buttonLaunchTests";
            this.buttonLaunchTests.Size = new System.Drawing.Size(163, 23);
            this.buttonLaunchTests.TabIndex = 7;
            this.buttonLaunchTests.Text = "Lancer le moteur de tests";
            this.buttonLaunchTests.UseVisualStyleBackColor = true;
            this.buttonLaunchTests.Click += new System.EventHandler(this.buttonLaunchTests_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Navigateur :";
            // 
            // radioButtonIE
            // 
            this.radioButtonIE.AutoSize = true;
            this.radioButtonIE.Checked = true;
            this.radioButtonIE.Location = new System.Drawing.Point(226, 43);
            this.radioButtonIE.Name = "radioButtonIE";
            this.radioButtonIE.Size = new System.Drawing.Size(102, 17);
            this.radioButtonIE.TabIndex = 5;
            this.radioButtonIE.TabStop = true;
            this.radioButtonIE.Text = "Internet Explorer";
            this.radioButtonIE.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirefox
            // 
            this.radioButtonFirefox.AutoSize = true;
            this.radioButtonFirefox.Location = new System.Drawing.Point(226, 20);
            this.radioButtonFirefox.Name = "radioButtonFirefox";
            this.radioButtonFirefox.Size = new System.Drawing.Size(56, 17);
            this.radioButtonFirefox.TabIndex = 4;
            this.radioButtonFirefox.Text = "Firefox";
            this.radioButtonFirefox.UseVisualStyleBackColor = true;
            // 
            // buttonFin
            // 
            this.buttonFin.Enabled = false;
            this.buttonFin.Location = new System.Drawing.Point(7, 66);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(163, 23);
            this.buttonFin.TabIndex = 3;
            this.buttonFin.Text = "Fin des tests";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonExec
            // 
            this.buttonExec.Enabled = false;
            this.buttonExec.Location = new System.Drawing.Point(7, 37);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(163, 23);
            this.buttonExec.TabIndex = 2;
            this.buttonExec.Text = "Executer le(s) scenario(s)";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // listBoxActions
            // 
            this.listBoxActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.Location = new System.Drawing.Point(3, 3);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(206, 524);
            this.listBoxActions.TabIndex = 1;
            this.listBoxActions.SelectedIndexChanged += new System.EventHandler(this.listBoxActions_SelectedIndexChanged);
            // 
            // tabPageXML
            // 
            this.tabPageXML.Controls.Add(this.tableLayoutPanel1);
            this.tabPageXML.Controls.Add(this.listBoxActionXML);
            this.tabPageXML.Location = new System.Drawing.Point(4, 22);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXML.Size = new System.Drawing.Size(817, 535);
            this.tabPageXML.TabIndex = 1;
            this.tabPageXML.Text = "Gestion des tests unitaires";
            this.tabPageXML.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelXML, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewXML, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(209, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.82798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.17202F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 529);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelXML
            // 
            this.panelXML.Controls.Add(this.buttonSaveScenar);
            this.panelXML.Controls.Add(this.textBoxDescAction);
            this.panelXML.Controls.Add(this.label2);
            this.panelXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXML.Location = new System.Drawing.Point(3, 420);
            this.panelXML.Name = "panelXML";
            this.panelXML.Size = new System.Drawing.Size(599, 106);
            this.panelXML.TabIndex = 3;
            // 
            // buttonSaveScenar
            // 
            this.buttonSaveScenar.Location = new System.Drawing.Point(422, 21);
            this.buttonSaveScenar.Name = "buttonSaveScenar";
            this.buttonSaveScenar.Size = new System.Drawing.Size(163, 23);
            this.buttonSaveScenar.TabIndex = 2;
            this.buttonSaveScenar.Text = "Sauvegarder les scenarios";
            this.buttonSaveScenar.UseVisualStyleBackColor = true;
            this.buttonSaveScenar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDescAction
            // 
            this.textBoxDescAction.Location = new System.Drawing.Point(10, 21);
            this.textBoxDescAction.Multiline = true;
            this.textBoxDescAction.Name = "textBoxDescAction";
            this.textBoxDescAction.Size = new System.Drawing.Size(288, 68);
            this.textBoxDescAction.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description de l\'action :";
            // 
            // dataGridViewXML
            // 
            this.dataGridViewXML.AllowUserToOrderColumns = true;
            this.dataGridViewXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXML.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewXML.Name = "dataGridViewXML";
            this.dataGridViewXML.Size = new System.Drawing.Size(599, 411);
            this.dataGridViewXML.TabIndex = 2;
            // 
            // listBoxActionXML
            // 
            this.listBoxActionXML.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxActionXML.FormattingEnabled = true;
            this.listBoxActionXML.Location = new System.Drawing.Point(3, 3);
            this.listBoxActionXML.Name = "listBoxActionXML";
            this.listBoxActionXML.Size = new System.Drawing.Size(206, 524);
            this.listBoxActionXML.TabIndex = 0;
            this.listBoxActionXML.SelectedIndexChanged += new System.EventHandler(this.listBoxActionXML_SelectedIndexChanged);
            // 
            // tabPageScenar
            // 
            this.tabPageScenar.Location = new System.Drawing.Point(4, 22);
            this.tabPageScenar.Name = "tabPageScenar";
            this.tabPageScenar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScenar.Size = new System.Drawing.Size(817, 535);
            this.tabPageScenar.TabIndex = 3;
            this.tabPageScenar.Text = "Scenarios de tests enregistrés";
            this.tabPageScenar.UseVisualStyleBackColor = true;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.buttonOptionModifier);
            this.tabPageOptions.Controls.Add(this.buttonActionSupprimer);
            this.tabPageOptions.Controls.Add(this.buttonOptionAjouter);
            this.tabPageOptions.Controls.Add(this.listBoxOption);
            this.tabPageOptions.Controls.Add(this.label1);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Size = new System.Drawing.Size(817, 535);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // buttonOptionModifier
            // 
            this.buttonOptionModifier.Location = new System.Drawing.Point(192, 59);
            this.buttonOptionModifier.Name = "buttonOptionModifier";
            this.buttonOptionModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonOptionModifier.TabIndex = 4;
            this.buttonOptionModifier.Text = "Modifier";
            this.buttonOptionModifier.UseVisualStyleBackColor = true;
            this.buttonOptionModifier.Visible = false;
            this.buttonOptionModifier.Click += new System.EventHandler(this.buttonOptionModifier_Click);
            // 
            // buttonActionSupprimer
            // 
            this.buttonActionSupprimer.Location = new System.Drawing.Point(192, 88);
            this.buttonActionSupprimer.Name = "buttonActionSupprimer";
            this.buttonActionSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonActionSupprimer.TabIndex = 3;
            this.buttonActionSupprimer.Text = "Supprimer";
            this.buttonActionSupprimer.UseVisualStyleBackColor = true;
            this.buttonActionSupprimer.Click += new System.EventHandler(this.buttonActionSupprimer_Click);
            // 
            // buttonOptionAjouter
            // 
            this.buttonOptionAjouter.Location = new System.Drawing.Point(192, 30);
            this.buttonOptionAjouter.Name = "buttonOptionAjouter";
            this.buttonOptionAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonOptionAjouter.TabIndex = 2;
            this.buttonOptionAjouter.Text = "Ajouter";
            this.buttonOptionAjouter.UseVisualStyleBackColor = true;
            this.buttonOptionAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxOption
            // 
            this.listBoxOption.FormattingEnabled = true;
            this.listBoxOption.Location = new System.Drawing.Point(11, 30);
            this.listBoxOption.Name = "listBoxOption";
            this.listBoxOption.Size = new System.Drawing.Size(174, 342);
            this.listBoxOption.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des tests disponibles : ";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 539);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(825, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.DefaultExt = "cs";
            this.openFileDialogMain.Filter = "Fichier C#|*.cs";
            this.openFileDialogMain.Title = "Choix de la nouvelle action";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 561);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "VS - Moteur de tests";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTest.ResumeLayout(false);
            this.splitContainerTests.Panel1.ResumeLayout(false);
            this.splitContainerTests.Panel2.ResumeLayout(false);
            this.splitContainerTests.ResumeLayout(false);
            this.tabControlTCPMon.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageAdmin.PerformLayout();
            this.panelMainTests.ResumeLayout(false);
            this.panelMainTests.PerformLayout();
            this.tabPageXML.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelXML.ResumeLayout(false);
            this.panelXML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).EndInit();
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.TabPage tabPageXML;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ListBox listBoxActionXML;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.Button buttonOptionModifier;
        private System.Windows.Forms.Button buttonActionSupprimer;
        private System.Windows.Forms.Button buttonOptionAjouter;
        private System.Windows.Forms.ListBox listBoxOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.Panel panelMainTests;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonIE;
        private System.Windows.Forms.RadioButton radioButtonFirefox;
        private System.Windows.Forms.Button buttonLaunchTests;
        private System.Windows.Forms.SplitContainer splitContainerTests;
        private System.Windows.Forms.CheckedListBox checkedListBoxTests;
        private System.Windows.Forms.TabPage tabPageScenar;
        private System.Windows.Forms.TabControl tabControlTCPMon;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.Button buttonTCPMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelXML;
        private System.Windows.Forms.Button buttonSaveScenar;
        private System.Windows.Forms.TextBox textBoxDescAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewXML;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonTCPMonCreate;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPortTo;
        private System.Windows.Forms.TextBox textBoxPortFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}