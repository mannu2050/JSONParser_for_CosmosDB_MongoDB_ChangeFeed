using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader f = new System.IO.StreamReader("json1.json");
            string jsonContent = f.ReadToEnd();
            int i = jsonContent.IndexOf("stockName");
            int j = jsonContent.Substring(i).IndexOf("$v");

            string stockSymbol = jsonContent.Substring( i+j+ 6,4);
            jsonContent = jsonContent.Substring(i + j + 10);
            i = jsonContent.IndexOf("stockValue");
            j = jsonContent.Substring(i).IndexOf("$v");
            
            string stockValue = jsonContent.Substring(j + i + 4, jsonContent.Substring(j + i).IndexOf("\n") - 4).Trim();

            jsonContent = jsonContent.Substring(i + j + 10);
            i = jsonContent.IndexOf("stockValueAt");
            j = jsonContent.Substring(i).IndexOf("$v");

            string stockValueAt = jsonContent.Substring(j + i + 4, jsonContent.Substring(j + i).IndexOf("\n") - 4).Trim();
        }
    }
}

           