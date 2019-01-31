using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for MathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello ";
        }
        [WebMethod]
        public string Hello(String s)
        {
            return "Hello " + s;
        }
        [WebMethod]
        public int Add(int a, int b)
        {

            return a + b;

        }


        [WebMethod]
        public double AddNNumbers(String s)
        {
            
            double total = 0;
            string[] tokens = s.Split(' ');
            foreach (string item in tokens)
            {
                total += double.Parse(item, CultureInfo.InvariantCulture);
            }

            //total = Convert.ToDouble(s.Split(','));
            return total;

        }
        [WebMethod]
        public System.Single Subtract(System.Single A, System.Single B)
        {
            return (A - B);
        }
        [WebMethod]
        public System.Single Divide(System.Single A, System.Single B)
        {
            if (B == 0)
                return -1;
            return Convert.ToSingle(A / B);
        }

        private void InitializeComponent()
        {

        }
    }
}
