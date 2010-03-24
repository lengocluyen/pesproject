using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public class PTheories : IDatafactory
{
    public PTheories()
    { }
    private static readonly PTheories instance = new PTheories();

    public static PTheories Instance
    {
        get { return PTheories.instance; }
    }
    #region Insert, Update, Delete
    /// <summary>
    /// Insert Theories
    /// </summary>
    /// <param name="ob">THEORIES</param>
    /// <returns>1 as success or -1 as fail</returns>
    public int Insert(Object ob)
    {
        try
        {
            DBChoose.GetDataContext().Theories.InsertOnSubmit(ob as Theory);
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
    /// Update Theories
    /// </summary>
    /// <param name="ob">THEORIES</param>
    /// <returns>1 as success or -1 as fail</returns>
    public int Update(Object ob)
    {
        try
        {
            Theory theonew = ob as Theory;
            Theory theoold = GetTheory(theonew.TheoryID);
            theoold.LessonID = theonew.LessonID;
            theoold.Contents = theonew.Contents;
            theoold.Description = theonew.Description;
            theoold.Active = theonew.Active;
            theoold.MediaFile = theonew.MediaFile;
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
    /// Delete Theories
    /// </summary>
    /// <param name="ob">THEORIES</param>
    /// <returns>1 as success or -1 as fail</returns>
    public int Delete(Object ob)
    {
        try
        {
            DBChoose.GetDataContext().Theories.DeleteOnSubmit(ob as Theory);
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

    #region
    /// <summary>
    /// GetObject Theory
    /// </summary>
    /// 
    /// <returns>list all Theory</returns>
    public IQueryable<Object> GetObject()
    {
        try
        {
            IQueryable<Theory> listTheories = DBChoose.GetDataContext().Theories;
            IQueryable<Object> list = (IQueryable<Object>)listTheories;
            return list;
        }
        catch
        {
            return null;
        }
    }
    /// <summary>
    /// GetTheory
    /// </summary>
    /// <param name="id">TheoryID</param>
    /// <returns>Theory</returns>
    public Theory GetTheory(int id)
    {
        return (from m in (IQueryable<Theory>)GetObject() where m.TheoryID == id select m).FirstOrDefault();
    }
    #endregion
}
