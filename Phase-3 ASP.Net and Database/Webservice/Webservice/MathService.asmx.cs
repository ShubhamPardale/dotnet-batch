﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Webservice
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
        public int Add(int A, int B)
        {
            return (A + B);
        }
        [WebMethod]
        public System.Single Subtract(System.Single A, System.Single B)
        {
            return (A - B);
        }
        [WebMethod]
        public System.Single Multiply(System.Single A, System.Single B)
        {
            return (A * B);
        }
        [WebMethod]
        public System.Single Divide(System.Single A, System.Single B)
        {
            if (B == 0) return -1;
            return Convert.ToSingle(A / B);
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "Method of diffrent project")]
        public string display()
        {
            localhost.WebService1 obj = new localhost.WebService1();
            return obj.show();
        }

    }
}
