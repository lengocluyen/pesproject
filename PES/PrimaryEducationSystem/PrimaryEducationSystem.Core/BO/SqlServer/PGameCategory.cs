using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public class PGameCategory : IDatafactory
{
    private static readonly PGameCategory instance = new PGameCategory();

    public static PGameCategory Instance
    {
        get { return PGameCategory.instance; }
    }

    #region Insert, Update, Delete
    /// <summary>
    /// GameCategory Insert
    /// </summary>
    /// <param name="ob">GAME_CATEGORYS</param>
    /// <returns>1 success or -1 fail</returns>
    public int Insert(object ob)
    {
        try
        {
            DBChoose.GetDataContext().GameCatelogies.InsertOnSubmit(ob as GameCatelogy);
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            return -1;
        }
    }
    /// <summary>
    /// GameCategory Update
    /// </summary>
    /// <param name="ob">GAME_CATEGORYS</param>
    /// <returns>1 success or -1 fail</returns>
    public int Update(object ob)
    {
        try
        {
            GameCatelogy gnew = ob as GameCatelogy;
            GameCatelogy gold = GetGameCateGory(gnew.GameCategoryID);
            gold.GameID = gnew.GameID;
            gold.GameCategoryname = gnew.GameCategoryname;
            gold.IsShowInHomePage = gnew.IsShowInHomePage;
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            return -1; ;
        }
    }
    /// <summary>
    /// GameCategory Delete
    /// </summary>
    /// <param name="ob">GAME_CATEGORYS</param>
    /// <returns>1 success or -1 fail</returns>
    public int Delete(object ob)
    {
        try
        {
            DBChoose.GetDataContext().GameCatelogies.DeleteOnSubmit(ob as GameCatelogy);
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
    /// Game_CateGory GetObject
    /// </summary>
    /// <returns>list all GAME_CATEGORYS</returns>
    public IQueryable<Object> GetObject()
    {
        IQueryable<GameCatelogy> listGamecategory = DBChoose.GetDataContext().GameCatelogies;
        IQueryable<Object> list = (IQueryable<Object>)listGamecategory;
        return list;
    }
    /// <summary>
    /// Get GameCategory
    /// </summary>
    /// <param name="id">GameCategoryID</param>
    /// <returns>GAME_CATEGORY</returns>
    public GameCatelogy GetGameCateGory(int id)
    {
        return (from m in (IQueryable<GameCatelogy>)GetObject() where m.GameCategoryID == id select m).FirstOrDefault();
    }
    #endregion

}
