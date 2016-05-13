/*******************************************************************************************************
Name: LOC HUYNH
Course: CSCE 4444 – Software Engineering
This class will hold data of a CnnHeadLine. At this point, we just need a title of a headline
Due Date: 10/05/2015, 11:55 PM
********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnncrawler.BL
{
    class CnnHeadLine
    {
        public CnnHeadLine()
        {
            _title = string.Empty;
        }

        string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
