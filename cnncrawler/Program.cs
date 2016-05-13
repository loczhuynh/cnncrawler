/*******************************************************************************************************
Name: LOC HUYNH
Course: CSCE 4444 – Software Engineering
Homework 1 - This program will visit the CNN website and pull the titles of the current news articles  
from the categories of: Tech, Travel, and Politics
Due Date: 10/05/2015, 11:55 PM
********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnncrawler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
