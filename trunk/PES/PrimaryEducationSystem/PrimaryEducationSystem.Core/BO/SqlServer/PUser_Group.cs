using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

namespace PrimaryEducationSystem.Core
{
    public class PUser_Group:IDatafactory
    {
        public PUser_Group()
        { }
        private static readonly PUser_Group instance = new PUser_Group();

        public static PUser_Group Instance
        {
            get { return PUser_Group.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// Insert UserGroup
        /// </summary>
        /// <param name="ob">USER_GROUP</param>
        /// <returns>1 if success or -1 if fail</returns>
        public int Insert(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().UserGroups.InsertOnSubmit(ob as UserGroup);
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
        /// Update UserGroup
        /// </summary>
        /// <param name="ob">USER_GROUP</param>
        /// <returns>1 if success or -1 if fail</returns>
        public int Update(Object ob)
        {
            try
            {
                UserGroup groupnew = ob as UserGroup;
                UserGroup groupold = GetUserGroup(groupnew.GroupID);
                groupold.RoleID = groupnew.RoleID;
                groupold.GroupName = groupnew.GroupName;
                groupold.Description = groupnew.Description;
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
        /// Delete UserGroup
        /// </summary>
        /// <param name="ob">USER_GROUP</param>
        /// <returns>1 if success or -1 if fail</returns>
        public int Delete(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().UserGroups.DeleteOnSubmit(ob as UserGroup);
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
        /// Insert UserGroup
        /// </summary>
        /// <returns>list all UserGroup</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<UserGroup> listUserGroup = DBChoose.GetDataContext().UserGroups;
                IQueryable<Object> list = (IQueryable<Object>)listUserGroup;
                return list;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// GetUserGroup
        /// </summary>
        /// <param name="id">GroupID</param>
        /// <returns>UserGroup</returns>
        public UserGroup GetUserGroup(int id)
        {
            return (from m in (IQueryable<UserGroup>)GetObject() where m.GroupID == id select m).FirstOrDefault();
        }
        #endregion



    }
}
