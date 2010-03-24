using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public class PLogs : IDatafactory
{

    public PLogs()
    { }
    private static readonly PLogs instance = new PLogs();

    public static PLogs Instance
    {
        get { return PLogs.instance; }
    }
    #region Insert, Update, Delete
    /// <summary>
    /// Logs Insert
    /// </summary>
    /// <param name="ob">LOGS</param>
    /// <returns>success or -1 fail</returns>
    public int Insert(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Logs.InsertOnSubmit(ob as Log);
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            DBClose.SubmitHandle();
            return -1;
        }
    }
    /// <summary>
    /// Log Delete
    /// </summary>
    /// <param name="ob">LOGS</param>
    /// <returns>success or -1 fail</returns>
    public int Delete(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Logs.DeleteOnSubmit(ob as Log);
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            DBClose.SubmitHandle();
            return -1;
        }
    }
    /// <summary>
    /// Log Update
    /// </summary>
    /// <param name="ob">LOGS</param>
    /// <returns>success or -1 fail</returns>
    public int Update(object ob)
    {
        try
        {
            Log log = ob as Log;
            Log updatelog = GetLogs(log.LogID);
            updatelog.Contents = log.Contents;
            updatelog.Date = log.Date;
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            DBClose.SubmitHandle();
            return -1;
        }
    }
    #endregion

    #region Utility
    /// <summary>
    /// Logs GetObject
    /// </summary>
    /// <returns>Logs getall</returns>
    public IQueryable<Object> GetObject()
    {

        IQueryable<Log> listlog = DBChoose.GetDataContext().Logs;
        IQueryable<Object> list = (IQueryable<Object>)listlog;
        return list;

    }
    /// <summary>
    /// Log GetLog
    /// </summary>
    /// <param name="id">LOGS</param>
    /// <returns>LOG</returns>
    public Log GetLogs(int id)
    {
        return (from m in (IQueryable<Log>)GetObject() where m.LogID == id select m).SingleOrDefault();

    }
    #endregion

}
