using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

namespace PrimaryEducationSystem.Core
{
    public class PUser:IDatafactory
    {
        public PUser()
        { }
        private static readonly PUser instance = new PUser();

        public static PUser Instance
        {
            get { return PUser.instance; }
        } 


        #region Insert, Update, Delete
        /// <summary>
        /// Insert Users
        /// </summary>
        /// <param name="ob">USERS</param>
        /// <returns>1 if success or -1 if fail</returns>
        public int Insert(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().Users.InsertOnSubmit(ob as User);
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
        /// Update Users
        /// </summary>
        /// <param name="ob">USERS</param>
        /// <returns>1 if success or -1 if fail</returns>
        public int Update(Object ob)
        {
            try
            {
                User usernew = ob as User;
                User userold = GetUser(usernew.UserID);
                userold.GroupID = usernew.GroupID;
                userold.FistName = usernew.FistName;
                userold.LastName = usernew.LastName;
                userold.UserName = usernew.UserName;
                userold.FamilyName = usernew.FamilyName;
                userold.Email = usernew.Email;
                userold.PassWord = usernew.PassWord;
                userold.Birthday = usernew.Birthday;
                userold.Address = usernew.Address;
                userold.Phone = usernew.Phone;
                userold.DateRegister = usernew.DateRegister;
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
        /// Delete Users
        /// </summary>
        /// <param name="ob">USERS</param>
        /// <returns>1 if success or -1 if fail</returns>
        public int Delete(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().Users.DeleteOnSubmit(ob as User);
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
        /// GetObject User
        /// </summary>
        /// <returns>list all User</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<User> listUser = DBChoose.GetDataContext().Users;
                IQueryable<Object> list = (IQueryable<Object>)listUser;
                return list;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Get User
        /// </summary>
        /// <param name="id">UserID</param>
        /// <returns>User</returns>
        public User GetUser(Guid id)
        {
            return (from m in (IQueryable<User>)GetObject() where m.UserID == id select m).FirstOrDefault();
        }
        #endregion 
    }
}
