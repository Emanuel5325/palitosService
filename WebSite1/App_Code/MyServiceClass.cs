using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ServiceClass
/// </summary>

[WebService]
public class MyServiceClass
{
    public MyServiceClass()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    [WebMethod]
    public string SayHello(string userName)
    {

        return string.Format("hello {0}", userName);

    }
}