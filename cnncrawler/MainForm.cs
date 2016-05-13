/*******************************************************************************************************
Name: LOC HUYNH
Course: CSCE 4444 – Software Engineering
Homework 1 - This program will visit the CNN website and pull the titles of the current news articles  
from the categories of: Tech, Travel, and Politics
Due Date: 10/05/2015, 11:55 PM
********************************************************************************************************/

using cnncrawler.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnncrawler
{
    public partial class frmMain : Form
    {
        const string CNN_TECH = "http://www.cnn.com/tech";
        const string CNN_POLITICS = "http://www.cnn.com/politics";
        const string CNN_TRAVEL = "http://www.cnn.com/travel";
        public frmMain()
        {
            InitializeComponent();
        }       
       
        /// <summary>
        /// This event will be fired when user clicks on the CrawCnnTech button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrawlCnnTech_Click(object sender, EventArgs e)
        {
            try
            {
                //clear all items of Cnn Tech list box
                lstCnnTech.Items.Clear();
                //Crawl cnn tech
                CrawlCnn(CNN_TECH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        /// <summary>
        /// This event will be fired when user clicks on the CrawCnnTravle button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrawlCnnTravel_Click(object sender, EventArgs e)
        {
            try
            {
                //clear all items of Cnn Travel list box
                lstCnnTravel.Items.Clear();
                //Crawl cnn travel
                CrawlCnn(CNN_TRAVEL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This event will be fired when user clicks on the CrawCnnPolitics button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrawlCnnPolitics_Click(object sender, EventArgs e)
        {
            try
            {
                //clear all items of Cnn Travel list box
                lstCnnPolitics.Items.Clear();
                //Crawl cnn Politics
                CrawlCnn(CNN_POLITICS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This function will download all Cnn website, then crawl all cnn head line
        /// </summary>
        /// <param name="urlAddress"></param>
        private void CrawlCnn(string urlAddress)
        {
            if (string.IsNullOrEmpty(urlAddress))
                return;

            //create a webclient object that can hold a dom documents for an url address
            Uri url = new Uri(urlAddress);
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            //start downloading cnn tech on different thread 
            client.DownloadStringAsync(url);
            client.DownloadStringCompleted += (sender, e) =>
            {
                if (e.Error == null)
                {
                    var data = e.Result;
                    //get all cnn head line of a cnn document which is existed in data variable.
                    List<CnnHeadLine> lstHeadLine = CnnCrawler.GetAllCnnHeadLine(data);

                    if (lstHeadLine == null)
                        return;

                    if (lstHeadLine.Count > 3)
                    {
                        //need to get 3 top headline, then update the result to GUI                                                   
                        for (int i = 0; i < 3; i++)
                        {
                            CnnHeadLine headLine = lstHeadLine[i];
                            if (urlAddress == CNN_TECH)
                            {
                                lstCnnTech.Items.Add(headLine.Title);
                            }
                            else if (urlAddress == CNN_POLITICS)
                            {
                                lstCnnPolitics.Items.Add(headLine.Title);
                            }
                            else //CNN_TRAVEL
                            {
                                lstCnnTravel.Items.Add(headLine.Title);
                            }
                        }
                    }
                    //done and have a list of coupons, need to update url for top 50 coupons
                    MessageBox.Show("Done. Successfully crawl: " + urlAddress);
                }
            };
        }
    }
}
