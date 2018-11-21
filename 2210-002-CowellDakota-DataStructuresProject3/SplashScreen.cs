///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject3/DataStructuresProject3
//	File Name:         SplashScreen.cs
//	Description:       Manages splash screen that appears when the application opens
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
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_002_CowellDakota_DataStructuresProject3
{
    /// <summary>
    /// Partial class to manage the Splash Screen Window
    /// Displays for 3.5 seconds and then closes on timer tick
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Constructor that initializes text fields based on the title and version in AssemblyInfo.cs
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            this.projectTitle.Text = AssemblyTitle;
            this.versionLabel.Text = String.Format("Version {0}", AssemblyVersion);
            this.authorLabel.Text = "Author: " + AssemblyCompany;
        }

        /// <summary>
        /// On timer tick, close the splash screen
        /// </summary>
        /// <param name="sender">Sender of the method</param>
        /// <param name="e">Event Arguments</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Assembly Attribute Accessors
        /// <summary>
        /// Property to retrieve the title from the AssemblyInfo.cs file
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
        /// Property to retrieve the Version of the project from AssemblyInfo.cs
        /// </summary>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// Property to retrieve the Author of the project from AssemblyInfo.cs
        /// </summary>
        public string AssemblyCompany
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
    }
}
