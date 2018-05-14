using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceText
{
    public class Text
    {
        public List<string> data = new List<string>();
        public void setData(string t)
        {
            data.Add(t);
    }
        public List<string> getdata()
        {
            return data;
        }
    }
}