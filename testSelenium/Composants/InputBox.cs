using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace testSelenium.Composants
{
	/// <summary>
	/// Description résumée de InputBox.
	/// </summary>
	public class frmInput : System.Windows.Forms.Form
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private System.Windows.Forms.Label lbl_prompt;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.TextBox txtB_response;

		public frmInput(string windowTitle, string question, string defaultText)
		{
			InitializeComponent();

			this.txtB_response.Text = defaultText;
			this.Text = windowTitle;
			this.lbl_prompt.Text = question;
		}

		public static string InputBox(string windowTitle, string question, string defaultText)
		{
			frmInput input = new frmInput(windowTitle, question, defaultText);

			try
			{
				if(input.ShowDialog() == DialogResult.OK)
				{
					return input.InputResponse;
				}
				else
					return null;
			}
			catch
			{
				return null;
			}
		}

		public string InputResponse
		{
			get{return this.txtB_response.Text;}
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>

		private void InitializeComponent()
		{
			this.lbl_prompt = new System.Windows.Forms.Label();
			this.btn_ok = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.txtB_response = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbl_prompt
			// 
			this.lbl_prompt.Location = new System.Drawing.Point(10, 13);
			this.lbl_prompt.Name = "lbl_prompt";
			this.lbl_prompt.Size = new System.Drawing.Size(270, 64);
			this.lbl_prompt.TabIndex = 1;
			// 
			// btn_ok
			// 
			this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_ok.Location = new System.Drawing.Point(289, 13);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(60, 22);
			this.btn_ok.TabIndex = 2;
			this.btn_ok.Text = "OK";
			// 
			// btn_cancel
			// 
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_cancel.Location = new System.Drawing.Point(289, 41);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(60, 22);
			this.btn_cancel.TabIndex = 3;
			this.btn_cancel.Text = "Annuler";
			// 
			// txtB_response
			// 
			this.txtB_response.Location = new System.Drawing.Point(10, 90);
			this.txtB_response.Name = "txtB_response";
			this.txtB_response.Size = new System.Drawing.Size(334, 20);
			this.txtB_response.TabIndex = 0;
			this.txtB_response.Text = "";
			// 
			// frmInput
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(352, 120);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.txtB_response,
																		  this.btn_cancel,
																		  this.btn_ok,
																		  this.lbl_prompt});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInput";
			this.ShowInTaskbar = false;
			this.ResumeLayout(false);

		}
		#endregion

	}
}
