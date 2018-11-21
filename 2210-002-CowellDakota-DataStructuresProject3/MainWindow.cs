///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject3/DataStructuresProject3
//	File Name:         MainWindow.cs
//	Description:       Manages main window of the application
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Dakota Cowell, cowelld@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Thursday, November 1, 2018
//	Copyright:         Dakota Cowell, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_002_CowellDakota_DataStructuresProject3
{
    /// <summary>
    /// Class to manage the Main Window of the application
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Class constructor - initializes the components and sets the text in the title bar to be the name of the project from the AssemblyInfo.cs
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.Text = AssemblyTitle + ", " + AssemblyAuthor;
        }

        /// <summary>
        /// Method to display the about window
        /// </summary>
        /// <param name="sender">Sender of the method</param>
        /// <param name="e">Event Argument</param>
        private void aboutInfixToPostFixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
        }

        /// <summary>
        /// Method to exit the program - Closes the main window
        /// </summary>
        /// <param name="sender">Sender of the method</param>
        /// <param name="e">Event Argument</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Assembly Attribute Accessors
        /// <summary>
        /// Property to keep track of the Title of the Project - Retrieved from AssemblyInfo.cs
        /// </summary>
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Property to keep track of the Title of the Project - Retrieved from AssemblyInfo.cs
        /// </summary>
        public string AssemblyAuthor
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        /// <summary>
        /// Called by the exit button
        /// Closes the program
        /// </summary>
        /// <param name="sender">Sender of the Method</param>
        /// <param name="e">Event Arguments</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Shows an open file dialog to allow the user to select a file to import Infix Expressions
        /// </summary>
        /// <param name="sender">Sender of the Method</param>
        /// <param name="e">Event Arguments</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create OpenFileDialog and set settings
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Text Files|*.txt";
            openDlg.Title = "Select a Text File";
            openDlg.InitialDirectory = @"..\..\TextFiles";

            //Show dialog
            if(openDlg.ShowDialog() != DialogResult.Cancel)
            {
                //Initialize StreamReader
                StreamReader rdr = null;

                try
                {
                    //Try to create StreamReader
                    rdr = new StreamReader(openDlg.FileName);

                    //Clear ListBox
                    infixExpressionListBox.Items.Clear();

                    //Loop through the file and add each line to the ListBox
                    while (rdr.Peek() != -1)
                    {
                        infixExpressionListBox.Items.Add(rdr.ReadLine());
                    }

                    //Set the SelectedIndex to the first item
                    infixExpressionListBox.SelectedIndex = 0;
                }
                finally{
                    //If the reader is not null, close it
                    if(rdr != null)
                    {
                        rdr.Close();
                    }
                }          
            }
        }

        /// <summary>
        /// When the selected index is changed in the ListBox, create a PostFix object and convert from Infix to PostFix and display it in the text boxes
        /// </summary>
        /// <param name="sender">Sender of the Method</param>
        /// <param name="e">Event Arguments</param>
        private void infixExpressionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the Selected Item is not null
            if(infixExpressionListBox.SelectedItem != null)
            {
                //Create PostFix object from the selected item's string value
                PostFix postFix = new PostFix(infixExpressionListBox.SelectedItem.ToString());

                //Convert the Infix Value to PostFix
                postFix.Convert();

                //Set the text boxes to their values
                infixTextBox.Text = postFix.InfixExpression;
                postFixTextBox.Text = postFix.PostFixExpression;
            }

        }

        /// <summary>
        /// Clears the infix and postfix textboxes 
        /// Called when the clear button is clicked
        /// </summary>
        /// <param name="sender">Sender of the method</param>
        /// <param name="e">Event Arguments</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            infixTextBox.Text = "";
            postFixTextBox.Text = "";
        }

        /// <summary>
        /// Generates the postfix value from the value in the Infix TextBox
        /// Called when the Generate PostFix button is selected
        /// </summary>
        /// <param name="sender">Sender of the method</param>
        /// <param name="e">Event Arguments</param>
        private void generatePostFixButton_Click(object sender, EventArgs e)
        {
            ///Make sure the text box is not empty
            if(infixTextBox.Text != "")
            {
                //Create PostFix Object and convert the infix to PostFix - Then, display the postfix value
                PostFix postFix = new PostFix(infixTextBox.Text);
                postFix.Convert();
                postFixTextBox.Text = postFix.PostFixExpression;
            }
        }
    }
}
