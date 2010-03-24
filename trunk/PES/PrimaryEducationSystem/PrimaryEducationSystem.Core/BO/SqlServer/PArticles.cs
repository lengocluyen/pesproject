using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public class PArticles : IDatafactory
{
    public PArticles()
    { }
    private static readonly PArticles instance = new PArticles();

    public static PArticles Instance
    {
        get { return PArticles.instance; }
    }
    #region insert, delete, update
    /// <summary>
    /// Article Insert
    /// </summary>
    /// <param name="ob">ARTICLES</param>
    /// <returns>1 success 1 or -1 fail</returns>
    public int Insert(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Artices.InsertOnSubmit(ob as Artice);
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
    /// Article Delete
    /// </summary>
    /// <param name="ob">ARTICLES</param>
    /// <returns>success 1 or -1 fail</returns>
    public int Delete(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Artices.DeleteOnSubmit(ob as Artice);
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
    /// Article Update
    /// </summary>
    /// <param name="ob">ARTICLES</param>
    /// <returns>success 1 or -1 fail</returns>
    public int Update(object ob)
    {
        try
        {
            Artice arnew = ob as Artice;
            Artice arold = this.GetArticle(arnew.ArticleID);
            arold.Contents = arnew.Contents;
            arold.Title = arnew.Title;
            arold.Date = arnew.Date;
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
    /// Artiicle GetObject
    /// </summary>
    /// <returns>Article list all</returns>
    public IQueryable<Object> GetObject()
    {
        IQueryable<Artice> listArticles = DBChoose.GetDataContext().Artices;
        IQueryable<Object> list = (IQueryable<Object>)listArticles;
        return list;
    }
    /// <summary>
    /// GetArticle
    /// </summary>
    /// <param name="id">ArticleID</param>
    /// <returns>ARTICLE</returns>
    public Artice GetArticle(int id)
    {
        return (from m in (IQueryable<Artice>)GetObject() where m.ArticleID == id select m).FirstOrDefault();
    }
    #endregion
}
