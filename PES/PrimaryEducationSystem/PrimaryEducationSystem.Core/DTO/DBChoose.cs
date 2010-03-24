using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Linq;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Runtime.Remoting.Messaging;
using PrimaryEducationSystem.Core.Database;

public class DBChoose
{
    static IDbConnection dbConnection;

    static DBChoose()
    {
        SetDbConnection();
    }


    public static PESDBDataContext GetDataContext()
    {
        if (HttpContext.Current != null)
        {
            if (HttpContext.Current.Items["MyDataContext"] == null)
                HttpContext.Current.Items["MyDataContext"] = new PESDBDataContext(dbConnection);
            return (PESDBDataContext)HttpContext.Current.Items["MyDataContext"];
        }
        else
        {
            PESDBDataContext context = CallContext.GetData("MyDataContext") as PESDBDataContext;
            if (context == null)
            {
                context = new PESDBDataContext(dbConnection);
                CallContext.SetData("MyDataContext", context);
            }
            return context;
        }
    }

    public static PESDBDataContext CreateDataContext()
    {
        return new PESDBDataContext(dbConnection);
    }

    static void SetDbConnection()
    {
        string provider = ConfigurationSettings.AppSettings.Get("ProviderDB");

        switch (provider)
        {
            case "SqlClient":
                dbConnection = new SqlConnection(ConfigurationSettings.AppSettings.Get("PESDBConnectionString"));
                break;
            case "OleDb":
                dbConnection = new OleDbConnection(ConfigurationSettings.AppSettings.Get("OleDbConnectionString"));
                break;
            case "Oracle":
                dbConnection = new OracleConnection(ConfigurationSettings.AppSettings.Get("OracleConnectionString"));
                break;
            default:
                dbConnection = new SqlConnection(ConfigurationSettings.AppSettings.Get("PESDBConnectionString"));
                break;
        }
    }
}
