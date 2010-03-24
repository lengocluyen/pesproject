using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public class PMailBox : IDatafactory
{
    private static readonly PMailBox instance = new PMailBox();

    public static PMailBox Instance
    {
        get { return PMailBox.instance; }
    }
    #region Insert, Update, Delete

    /// <summary>
    /// Mail_Box Insert 
    /// </summary>
    /// <param name="ob">MAIL_BOXS</param>
    /// <returns>1(success) or -1 (fail)</returns>
    public int Insert(object ob)
    {
        try
        {
            DBChoose.GetDataContext().MailBoxes.InsertOnSubmit(ob as MailBox);
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            return -1;
        }
    }
    /// <summary>
    /// Mail_Box Update
    /// </summary>
    /// <param name="ob">MAIL_BOXS</param>
    /// <returns>1(success) or -1 (fail)</returns>
    public int Update(object ob)
    {
        try
        {
            MailBox mbnew = ob as MailBox;
            MailBox mbold = GetMailBox(mbnew.MailBoxID);
            mbold.UserID = mbnew.UserID;
            mbold.Subject = mbnew.Subject;
            mbold.Contents = mbnew.Contents;
            mbold.Type = mbnew.Type;
            mbold.UserSend = mbnew.UserSend;
            mbold.Active = mbnew.Active;
            return 1;
        }
        catch
        {
            return -1;
        }
    }
    /// <summary>
    /// Mail_Box delete
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int Delete(object ob)
    {
        try
        {
            DBChoose.GetDataContext().MailBoxes.DeleteOnSubmit(ob as MailBox);
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
    /// Get all MailBox
    /// </summary>
    /// <returns>MAIL_BOXS(success) </returns>
    public IQueryable<Object> GetObject()
    {
        try
        {
            IQueryable<MailBox> mailBoxList = DBChoose.GetDataContext().MailBoxes;
            IQueryable<Object> list = (IQueryable<Object>)mailBoxList;
            return list;
        }
        catch
        {
            return null;
        }
    }
    /// <summary>
    /// Get MailBox
    /// </summary>
    /// <param name="id">MailBoxID</param>
    /// <returns>MAIL_BOX (success) null (fail)</returns>
    public MailBox GetMailBox(int id)
    {
        try
        {
            return (from m in (IQueryable<MailBox>)GetObject() where m.MailBoxID == id select m).FirstOrDefault();
        }
        catch
        {
            return null;
        }
    }
    #endregion

}
