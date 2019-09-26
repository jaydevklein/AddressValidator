using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/*
 * Author: J. Klein
 * Date: 9/2019
 * Description: the form captures a US-based address information and validates the format and verifies that it 
 * is a valid USPS address.
 * 
 * Required fields:
 * Street address, City, State, Zip
 * 
 * Optional fields:
 * Secondary address, Apartment, suite number.
*/

namespace AddressValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate1_Clicked(object sender, EventArgs e)
        {

            int validate_USPSAddress_return;
            int validate_RequiredFields_return;
            string validationMessage;

            AddressTester addressTester = new AddressTester();

            lblValidationMessage.Text = "";

            validate_RequiredFields_return = addressTester.validate_RequiredFields(
                txtAddress1.Text,
                txtCity.Text,
                cmbState.Text,
                Regex.Replace(mtxtZip.Text, @"[ -]", ""),    // remove mask (spaces and dash)
                out validationMessage);

            if (validate_RequiredFields_return != 0)
            {
                lblValidationMessage.Text = validationMessage;
                return;
            }

            validate_USPSAddress_return = addressTester.validate_USPSAddress(
                txtAddress1.Text,
                txtAddress2.Text,
                txtCity.Text,
                cmbState.Text,
                Regex.Replace(mtxtZip.Text, @"[ -]", "")    // remove mask (spaces and dash)
                );

            switch (validate_USPSAddress_return)
            {
                case 0:
                    lblValidationMessage.Text = "The address is a valid USPS location.";
                    break;
                case 1:
                    lblValidationMessage.Text = "The address is not a valid USPS location. Please verify your input.";
                    break;
                case 2:
                    lblValidationMessage.Text = "The Zip Code does not correspond to the State. Please verify your input.";
                    break;
                case 3:
                    lblValidationMessage.Text = "The Zip Code does not correspond to the City/State. Please verify your input.";
                    break;
                case 4:
                    lblValidationMessage.Text = "The City is misspelled or it does not correspond to the Zip Code. Please verify your input.";
                    break;
                case -1:
                    lblValidationMessage.Text = "There was an error validating the USPS address. Please contact IT support";
                    break;
                case -2:
                    lblValidationMessage.Text = "There was an error validating the USPS address. Please contact IT support";
                    break;
                default:
                    lblValidationMessage.Text = "There was an error validating the USPS address. Please contact IT support";
                    break;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void mtxtZip_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxtZip.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the Zip Code field.", mtxtZip, 0, -20, 5000);
            }
            else if (e.Position == mtxtZip.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this Zip Code field.", mtxtZip, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this Zip Code field.", mtxtZip, 0, -20, 5000);
            }
        }

        void mtxtZip_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(mtxtZip);
        }

    }
}
