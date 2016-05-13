/*******************************************************************************************************
Name: LOC HUYNH
Course: CSCE 4444 – Software Engineering
This class will get all CnnHeadLine object from a input html string
Due Date: 10/05/2015, 11:55 PM
********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnncrawler.BL
{
    class CnnCrawler
    {
        /// <summary>
        /// This function will get all CnnHeadLine object from a html string
        /// </summary>
        /// <param name="html">input html string</param>
        /// <returns>List of CnnHeadLine</returns>
        public static List<CnnHeadLine> GetAllCnnHeadLine(string html)
        {
            //return null if the html string is null or empty
            if (string.IsNullOrEmpty(html))
                return null;

            List<CnnHeadLine> lstHeadLine = new List<CnnHeadLine>();

            //using HtmlAgilityPack to get document content of the url
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            if (doc != null)
            {
                //need a root node of the html document
                var node = doc.DocumentNode;

                //all cnn head line has a dom structure as below: 
                //div[@class='cd__content']//h3[@class='cd__headline']//span[@class='cd__headline-text']
                //we use xpath to get all the headlineNodes
                var headLineNodes = node.SelectNodes("//div[@class='cd__content']//h3[@class='cd__headline']//span[@class='cd__headline-text']");
                if (headLineNodes != null)
                {
                    var headLineList = headLineNodes.ToList();                    
                    foreach (HtmlAgilityPack.HtmlNode headLineNode in headLineList)
                    {
                        //creat each CnnHeadLine object, then add it to the Cnn Head Line list
                        CnnHeadLine headLine = new CnnHeadLine();
                        headLine.Title = headLineNode.InnerText;
                        lstHeadLine.Add(headLine);
                    }
                }
            }

            //return the list 
            return lstHeadLine;
        }
    }
}
