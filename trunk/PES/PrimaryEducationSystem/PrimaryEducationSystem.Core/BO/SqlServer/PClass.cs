using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PrimaryEducationSystem.Core.Database;

public class PClass : IDatafactory
{
    private static readonly PClass instance = new PClass();

    public static PClass Instance
    {
        get { return PClass.instance; }
    }

    #region insert, update, delete
    /// <summary>
    /// Insert Class 
    /// </summary>
    /// <param name="ob">CLASSS</param>
    /// <returns>1 success or -1 fail</returns>
    public int Insert(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Classes.InsertOnSubmit(ob as Class);
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
    /// Update Class
    /// </summary>
    /// <param name="ob">CLASSS</param>
    /// <returns>success or -1 fail</returns>
    public int Update(object ob)
    {
        try
        {
            Class clnew = ob as Class;
            Class clold = GetClass(clnew.ClassID);
            clold.ClassName = clnew.ClassName;
            clold.MediaFile = clnew.MediaFile;
            DBClose.SubmitHandle();
            return 1;

        }
        catch
        {
            return -1;
        }
    }
    /// <summary>
    /// Delete Class
    /// </summary>
    /// <param name="ob">CLASSS</param>
    /// <returns>success or -1 fail</returns>
    public int Delete(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Classes.DeleteOnSubmit(ob as Class);
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            return -1;
        }
    }

    #endregion
    #region Utility
    /// <summary>
    /// GetObject Class
    /// </summary>
    /// <returns>list all Class</returns>
    public IQueryable<Object> GetObject()
    {
        IQueryable<Class> listClass = DBChoose.GetDataContext().Classes;
        IQueryable<Object> list = (IQueryable<Object>)listClass;
        return list;
    }
    /// <summary>
    /// GetClass Class
    /// </summary>
    /// <param name="id">ClassID</param>
    /// <returns>Class</returns>
    public Class GetClass(int id)
    {
        return (from m in (IQueryable<Class>)GetObject() where m.ClassID == id select m).FirstOrDefault();
    }
    #endregion
}
