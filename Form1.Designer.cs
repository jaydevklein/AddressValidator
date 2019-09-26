using System.Windows.Forms;

namespace AddressValidator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.mtxtZip = new System.Windows.Forms.MaskedTextBox();
            this.btnValidate1 = new System.Windows.Forms.Button();
            this.lblValidationMessage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(37, 66);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(83, 13);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "* Street Address";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(125, 66);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(146, 20);
            this.txtAddress1.TabIndex = 1;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(19, 103);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(101, 13);
            this.lblAddress2.TabIndex = 2;
            this.lblAddress2.Text = "Apt. or suite number";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(126, 103);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(146, 20);
            this.txtAddress2.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(89, 143);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "* City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 144);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(146, 20);
            this.txtCity.TabIndex = 5;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(303, 144);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(39, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "* State";
            // 
            // cmbState
            // 
            this.cmbState.DropDownHeight = 132;
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.IntegralHeight = false;
            this.cmbState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DC",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.cmbState.Location = new System.Drawing.Point(341, 143);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(56, 21);
            this.cmbState.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(433, 144);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(57, 13);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "* Zip Code";
            // 
            // mtxtZip
            // 
            this.mtxtZip.Location = new System.Drawing.Point(489, 144);
            this.mtxtZip.Mask = "00000-9999";
            this.mtxtZip.Name = "mtxtZip";
            this.mtxtZip.Size = new System.Drawing.Size(71, 20);
            this.mtxtZip.TabIndex = 9;
            this.mtxtZip.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtZip_MaskInputRejected);
            this.mtxtZip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtZip_KeyDown);
            // 
            // btnValidate1
            // 
            this.btnValidate1.Location = new System.Drawing.Point(125, 192);
            this.btnValidate1.Name = "btnValidate1";
            this.btnValidate1.Size = new System.Drawing.Size(119, 30);
            this.btnValidate1.TabIndex = 10;
            this.btnValidate1.Text = "Validate Address";
            this.btnValidate1.UseVisualStyleBackColor = true;
            this.btnValidate1.Click += new System.EventHandler(this.btnValidate1_Clicked);
            // 
            // lblValidationMessage
            // 
            this.lblValidationMessage.AutoSize = true;
            this.lblValidationMessage.Location = new System.Drawing.Point(123, 249);
            this.lblValidationMessage.Name = "lblValidationMessage";
            this.lblValidationMessage.Size = new System.Drawing.Size(0, 13);
            this.lblValidationMessage.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "* = Required fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter a valid USPS address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.mtxtZip);
            this.Controls.Add(this.lblValidationMessage);
            this.Controls.Add(this.btnValidate1);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtAddress1);
            this.Name = "Form1";
            this.Text = "Address Validator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Button btnValidate1;
        private System.Windows.Forms.Label lblValidationMessage;
        private System.Windows.Forms.MaskedTextBox mtxtZip;
        private System.Windows.Forms.ComboBox cmbState;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
    }
}

