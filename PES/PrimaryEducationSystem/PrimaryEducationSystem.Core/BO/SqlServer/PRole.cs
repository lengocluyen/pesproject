using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public class PRole : IDatafactory
{
    public PRole()
    { }
    //Khai bao mot the hien ten la instance thuoc kieu PReply
    private static readonly PRole instance = new PRole();

    public static PRole Instance
    {
        get { return PRole.instance; }
    }
    #region Insert, Update, Delete
    /// <summary>
    /// Insert Role
    /// </summary>
    /// <param name="ob">ROLE</param>
    /// <returns>1 success or -1 fail</returns>
    public int Insert(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Roles.InsertOnSubmit(ob as Role);
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
    /// Update Role
    /// </summary>
    /// <param name="ob">ROLE</param>
    /// <returns>1 success or -1 fail</returns>
    public int Update(Object ob)
    {
        try
        {
            Role rolnew = ob as Role;
            Role rolold = GetRole(rolnew.RoleID);
            rolold.RoleName = rolnew.RoleName;
            rolold.Active = rolnew.Active;
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
    /// Delete Role
    /// </summary>
    /// <param name="ob">ROLE</param>
    /// <returns>1 success or -1 fail</returns>
    public int Delete(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Roles.DeleteOnSubmit(ob as Role);
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

    #region Ultility
    /// <summary>
    /// GetObject Role
    /// </summary>
    /// <returns>list all role</returns>
    public IQueryable<Object> GetObject()
    {
        IQueryable<Role> listReply = DBChoose.GetDataContext().Roles;
        IQueryable<Object> list = (IQueryable<Object>)listReply;
        return list;
    }
    /// <summary>
    /// GetRole
    /// </summary>
    /// <param name="id">RoleID</param>
    /// <returns>Role</returns>
    public Role GetRole(int id)
    {
        return (from m in (IQueryable<Role>)GetObject() where m.RoleID == id select m).FirstOrDefault();
    }
    #endregion

}
