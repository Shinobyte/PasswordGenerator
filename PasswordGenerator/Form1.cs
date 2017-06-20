using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class passwordGenerator : Form
    {
        public passwordGenerator()

        /* Program to generate passwords based on user input
        * Copyright (C) 2017 Alex van der Waal - All Rights Reserved
        * Last revised 20170619 */

        {
            InitializeComponent();

            /* The backgroundworker object on which the time consuming operation shall be executed.
             * Needs to be in this scope with initializeComponent! */
            bgw_generatePasswords = new BackgroundWorker();

            /* Create a background worker thread that ReportsProgress & SupportsCancellation. 
             * Hook up the appropriate events. */
            bgw_generatePasswords.DoWork += Bgw_generatePasswords_DoWork;
            bgw_generatePasswords.ProgressChanged += Bgw_generatePasswords_ProgressChanged;
            bgw_generatePasswords.RunWorkerCompleted += Bgw_generatePasswords_RunWorkerCompleted;
            bgw_generatePasswords.WorkerReportsProgress = true;
            bgw_generatePasswords.WorkerSupportsCancellation = true;

            // Disable the Stop button on form, it gets enabled when the user hits generate.
            btnCancel.Enabled = false;
        }


        // On completed background worker do the appropriate task.
        void Bgw_generatePasswords_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            /* The background process is complete. We need to inspect our response to see if an
             *  error occurred, a cancel was requested or if we completed successfully.  */
            if (e.Cancelled)
            {
                lblStatus.Text = "Password generation cancelled.";
            }

            // Check to see if an error occurred in the background process.
            else if (e.Error != null)
            {
                lblStatus.Text = "Error during operation.";
            }
            else
            {
                // Everything completed normally.
                lblStatus.Text = "Password generation complete.";
            }

            //Change the status of the buttons on the UI accordingly.
            btnStartAsyncOperation.Enabled = true;
            btnCancel.Enabled = false;
        }

        // The progress bar is updated here on every called bgw_generatePasswords.ReportProgress(percentage).
        void Bgw_generatePasswords_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progressBar with the integer supplied to us from the ReportProgress() function.
            pbr_PlayProgression.Value = e.ProgressPercentage;
            lblStatus.Text = "Generating passwords ..." + pbr_PlayProgression.Value.ToString() + "%";

            // Password result to textbox on screen.
            tbx_passwordOutput.Text = passwordBuilder.ToString();
        }

        /* Declare stringbuilder outside of Bgw_generatePasswords_DoWork so it can be called by 
         * Bgw_generatePasswords_ProgressChanged. */
        public StringBuilder passwordBuilder = new StringBuilder();

        // Start of actual work on seperate thread. Time consuming operations go here!
        public void Bgw_generatePasswords_DoWork(object sender, DoWorkEventArgs e)
        {
            // Declare variables.
            string inputAmount = tbx_Amount.Text;
            string inputLength = tbx_Length.Text;
            
            // Pass input on trough the GetNumericInput(). // Method
            int valueAmount = GetNumericInput(inputAmount);
            
            // Pass input on trough the GetNumericInput(). // Method
            int valueLength = GetNumericInput(inputLength);

            // Declare counter outside of the for loop below.
            int counter = 0;

            /* Increment the integer [i] and iterate untill you reach the numbers the user has 
             * provided. Do this for amount of passwords and lenghts of pasword, double loop. */
            passwordBuilder.Clear();
            for (int j = 0; j < valueAmount; j++)
            {
                for (int i = 0; i < valueLength; i++)
                {
                    passwordBuilder.Append(passwordSingleChar());
                }

                /* Check if user initiated a cancel during playback, if so set the e.Cancel flag
                 * so that the WorkerCompleted event knows that the process was cancelled. */
                if (bgw_generatePasswords.CancellationPending)
                {
                    e.Cancel = true;
                    bgw_generatePasswords.ReportProgress(0);
                    return;
                }

                // Do the math to update the progressbar with the right percentage.
                counter += 1;
                int percentage = (counter * 100) / valueAmount;
                bgw_generatePasswords.ReportProgress(percentage);

                // Append line so the passwords are shown on seperate lines in the tbx_passwordOutput.
                passwordBuilder.AppendLine();

            }
            //Report 100% completion on operation completed
            bgw_generatePasswords.ReportProgress(100);
        }


        // Create list with base characters for password generation.
        public static List<string> AvailableCharacters = new List<string> {
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
        "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
        };


        /* Create a method. Instance of Random class, seed based on curent time
        * Create [int index] in the range of 0 > list length and store
        * the character from that position in the list [value]. */
        static string getChar() // Method
        {
            Random rnd = new Random((int)System.DateTime.Now.Ticks);
            int index = rnd.Next(0, AvailableCharacters.Count);
            string value = AvailableCharacters[index];
            return (value);
        }


        // Sleep to generate new rnd seed, get output of method [getChar].
        static string passwordSingleChar() // Method
        {
            Thread.Sleep(10);
            return getChar();
        }


        // Create a method. Ask numeric input from user, check if it is numeric and no larger then 512.
        public static int value;
        private int GetNumericInput(string input) // Method
        {
            foreach (char character in input)
            {
                if (int.TryParse(input, out value))
                {
                    if (value > 512)
                    {
                        MessageBox.Show("Maximum value is 512.");
                    }
                    return value;
                }
                else if (!int.TryParse(input, out value))
                {
                    MessageBox.Show("Please enter a numeric value.\n");
                }
            }
            return value;
        }


        ///
        ///Form Inputs below this point.
        ///


        private void lbl_about_Click(object sender, EventArgs e)
        {
            // (About) Show an About messagebox to user. 
            MessageBox.Show("Program:\t\tPassword Generator\nAuthor:\t\tAlex van der Waal\n.NETFramework:\tv4.6.2\n\nCopyright:\t© 2017 Shinobyte\n\t\t" +
                "All rights reserved.\n\nWebsite:\t\twww.shinobyte.com");
        }


        private void tbx_Length_TextChanged(object sender, EventArgs e)
        {
            // Get input from textbox.
            string inputLength = tbx_Length.Text;
            
            // Pass input on trough the GetNumericInput(). // Method
            GetNumericInput(inputLength);
        }


        private void tbx_Amount_TextChanged(object sender, EventArgs e)
        {
            // Get input from textbox.
            string inputAmount = tbx_Amount.Text;

            // Pass input on trough the GetNumericInput(). // Method
            GetNumericInput(inputAmount);
        }


        /* Make the borderless form movable. Tricks the window manager into thinking that it is 
         * grabbing the titlebar of the winform. Applied via mousedown. */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void passwordGenerator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //Clear input fields once clicked on.
        private void tbx_Length_Click(object sender, EventArgs e)
        {
            tbx_Length.Clear();
        }


        private void tbx_Amount_Click(object sender, EventArgs e)
        {
            tbx_Amount.Clear();
        }


        private void btnStartAsyncOperation_Click(object sender, EventArgs e)
        {
            /*Change the status of the buttons on the UI accordingly
             * The start button is disabled as soon as the background operation is started
             * The Cancel button is enabled so that the user can cancel the operation */
            btnStartAsyncOperation.Enabled = false;
            btnCancel.Enabled = true;

            // Kickoff the worker thread to begin it's DoWork function.
            bgw_generatePasswords.RunWorkerAsync();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel the worker thread in the DoWork function.
            bgw_generatePasswords.CancelAsync();
        }


        private void lbl_topRightX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_ClipboardAll_Click(object sender, EventArgs e)
        {
            // Only copy to clipboard if textbox has values, else show popup.
            if (string.IsNullOrEmpty(tbx_passwordOutput.Text))
            {
                MessageBox.Show("There is nothing to copy.");
            }
            else
                Clipboard.SetText(tbx_passwordOutput.Text);
        }


        private void btn_ClipboardSelection_Click(object sender, EventArgs e)
        {
            // Only copy to clipboard if textbox has selected values, else show popup.
            if (tbx_passwordOutput.SelectedText.Equals(""))
            {
                MessageBox.Show("You have nothing selected.");
            }
            else
                Clipboard.SetText(tbx_passwordOutput.SelectedText);
        }


        private void checkBox_upperCase_CheckedChanged(object sender, EventArgs e)
        {
            // Add or Remove uppercase dependant on check state.
            if (checkBox_upperCase.Checked)
            {
                AvailableCharacters.Add("A");
                AvailableCharacters.Add("B");
                AvailableCharacters.Add("C");
                AvailableCharacters.Add("D");
                AvailableCharacters.Add("E");
                AvailableCharacters.Add("F");
                AvailableCharacters.Add("G");
                AvailableCharacters.Add("H");
                AvailableCharacters.Add("I");
                AvailableCharacters.Add("J");
                AvailableCharacters.Add("K");
                AvailableCharacters.Add("L");
                AvailableCharacters.Add("M");
                AvailableCharacters.Add("N");
                AvailableCharacters.Add("O");
                AvailableCharacters.Add("P");
                AvailableCharacters.Add("Q");
                AvailableCharacters.Add("R");
                AvailableCharacters.Add("S");
                AvailableCharacters.Add("T");
                AvailableCharacters.Add("U");
                AvailableCharacters.Add("V");
                AvailableCharacters.Add("W");
                AvailableCharacters.Add("X");
                AvailableCharacters.Add("Y");
                AvailableCharacters.Add("Z");
            }

            if (!checkBox_upperCase.Checked)
            {
                AvailableCharacters.Remove("A");
                AvailableCharacters.Remove("B");
                AvailableCharacters.Remove("C");
                AvailableCharacters.Remove("D");
                AvailableCharacters.Remove("E");
                AvailableCharacters.Remove("F");
                AvailableCharacters.Remove("G");
                AvailableCharacters.Remove("H");
                AvailableCharacters.Remove("I");
                AvailableCharacters.Remove("J");
                AvailableCharacters.Remove("K");
                AvailableCharacters.Remove("L");
                AvailableCharacters.Remove("M");
                AvailableCharacters.Remove("N");
                AvailableCharacters.Remove("O");
                AvailableCharacters.Remove("P");
                AvailableCharacters.Remove("Q");
                AvailableCharacters.Remove("R");
                AvailableCharacters.Remove("S");
                AvailableCharacters.Remove("T");
                AvailableCharacters.Remove("U");
                AvailableCharacters.Remove("V");
                AvailableCharacters.Remove("W");
                AvailableCharacters.Remove("X");
                AvailableCharacters.Remove("Y");
                AvailableCharacters.Remove("Z");
            }

        }


        private void checkBox_digits_CheckedChanged(object sender, EventArgs e)
        {
            // Add or Remove numbers dependant on check state.
            if (checkBox_digits.Checked)
            {
                AvailableCharacters.Add("0");
                AvailableCharacters.Add("1");
                AvailableCharacters.Add("2");
                AvailableCharacters.Add("3");
                AvailableCharacters.Add("4");
                AvailableCharacters.Add("5");
                AvailableCharacters.Add("6");
                AvailableCharacters.Add("7");
                AvailableCharacters.Add("8");
                AvailableCharacters.Add("9");
            }

            if (!checkBox_digits.Checked)
            {
                AvailableCharacters.Remove("0");
                AvailableCharacters.Remove("1");
                AvailableCharacters.Remove("2");
                AvailableCharacters.Remove("3");
                AvailableCharacters.Remove("4");
                AvailableCharacters.Remove("5");
                AvailableCharacters.Remove("6");
                AvailableCharacters.Remove("7");
                AvailableCharacters.Remove("8");
                AvailableCharacters.Remove("9");
            }

        }


        private void checkBox_space_CheckedChanged(object sender, EventArgs e)
        {
            // Add or Remove space dependant on check state.
            if (checkBox_space.Checked)
            {
                AvailableCharacters.Add(" ");
            }

            if (!checkBox_space.Checked)
            {
                AvailableCharacters.Remove(" ");
            }
        }


        private void checkBox_minus_CheckedChanged(object sender, EventArgs e)
        {
            // Add or Remove minus dependant on check state.
            if (checkBox_minus.Checked)
            {
                AvailableCharacters.Add("-");
            }

            if (!checkBox_minus.Checked)
            {
                AvailableCharacters.Remove("-");
            }
        }


        private void checkBox_underLine_CheckedChanged(object sender, EventArgs e)
        {
            // Add or Remove underline dependant on check state.
            if (checkBox_underLine.Checked)
            {
                AvailableCharacters.Add("_");
            }

            if (!checkBox_underLine.Checked)
            {
                AvailableCharacters.Remove("_");
            }
        }

        private void lbl_topRightMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void pic_Shinobyte_Click(object sender, EventArgs e)
        {
            // Launch browser to Shinobyte after click on logo.
            System.Diagnostics.Process.Start("http://www.shinobyte.com");
        }


        private void checkBox_special_CheckedChanged(object sender, EventArgs e)
        {
            // Add or Remove special characters dependant on check state.
            if (checkBox_special.Checked)
            {
                AvailableCharacters.Add("!");
                AvailableCharacters.Add("@");
                AvailableCharacters.Add("#");
                AvailableCharacters.Add("$");
                AvailableCharacters.Add("%");
                AvailableCharacters.Add("^");
                AvailableCharacters.Add("&");
                AvailableCharacters.Add("*");
            }

            if (!checkBox_special.Checked)
            {
                AvailableCharacters.Remove("!");
                AvailableCharacters.Remove("@");
                AvailableCharacters.Remove("#");
                AvailableCharacters.Remove("$");
                AvailableCharacters.Remove("%");
                AvailableCharacters.Remove("^");
                AvailableCharacters.Remove("&");
                AvailableCharacters.Remove("*");
            }
        }
    }
}


