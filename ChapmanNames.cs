// Author:  Kyle Chapman
// Date:    January 18, 2021
// Description:
//  This totally absurd application is designed to tell you
//  whether an entered name is a valid name for someone in
//  Kyle's immediate family. Validates the presence of the
//  letter "y" in entered names and reports some stats about
//  entries.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapmanNames
{
    public partial class formChapmanNames : Form
    {
        // Global variables.
        int validNamesAccepted = 0;
        int totalLength = 0;

        public formChapmanNames()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit click: closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Reset the form to its default state with cleared input and output fields, and focus set appropriately.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear all input and output fields.
            textBoxNameInput.Clear();
            textBoxNameList.Clear();
            labelOutput.Text = String.Empty;

            // Reset the global variables.
            totalLength = 0;
            validNamesAccepted = 0;

            // Set focus.
            textBoxNameInput.Focus();
        }

        /// <summary>
        /// For an entered name, check whether there is a letter "y" in the first or second position. If so, it's valid and is recorded. Statistical data is also accumulated and output.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Constant declarations.
            const string TargetLetter = "y";
            const int MinimumLength = 3;

            // Does the entered name have at least three letters?
            if (textBoxNameInput.Text.Length >= MinimumLength)
            {
                string secondLetter = textBoxNameInput.Text.Substring(1, 1);
                string thirdLetter = textBoxNameInput.Text.Substring(2, 1);

                // Does the entered name have 2nd character or 3rd character as "y"?
                if (secondLetter == TargetLetter || thirdLetter == TargetLetter)
                {
                    // Increment global variables based on the value entered.
                    validNamesAccepted++;
                    totalLength += textBoxNameInput.Text.Length;

                    // Append the new name to the name list textbox.
                    textBoxNameList.Text += textBoxNameInput.Text + "\r\n";

                    // Modify the output label with stats.
                    labelOutput.Text = validNamesAccepted + " names entered so far. Average length: " + totalLength / validNamesAccepted;

                    // Clear input!
                    textBoxNameInput.Clear();
                }
                else
                {
                    // The "y" is not in the right position. Report error and set focus.
                    MessageBox.Show("Valid Chapman names have the 2nd or 3rd letter as \""+ TargetLetter + "\".");
                    textBoxNameInput.SelectAll();
                    textBoxNameInput.Focus();
                }
            }
            else
            {
                // The name is too short. Report error and set focus.
                MessageBox.Show("The entered name is too short for valid Chapman naming rules. Minimum is " + MinimumLength + ".");
                textBoxNameInput.SelectAll();
                textBoxNameInput.Focus();
            }
        }
    }
}
