using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

namespace PrimaryEducationSystem.Core
{
    /// <summary>
    /// Reply
    /// </summary>
    public class PReply:IDatafactory
    {
        public PReply()
        { }
        //Khai bao mot the hien ten la instance thuoc kieu PReply
        private static readonly PReply instance = new PReply();

        public static PReply Instance
        {
            get { return PReply.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// Insert Reply
        /// </summary>
        /// <param name="ob">REPLYS</param>
        /// <returns>success or -1 fail</returns>
        public int Insert(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Replies.InsertOnSubmit(ob as Reply);
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
        /// Update Reply
        /// </summary>
        /// <param name="ob">REPLYS</param>
        /// <returns>success or -1 fail</returns>
        public int Update(Object ob)
        {
            try
            {
                Reply repnew = ob as Reply;
                Reply repold = GetReply(repnew.ReplyID);
                repold.QuestionID = repnew.QuestionID;
                repold.Contents = repnew.Contents;
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
        /// Delete Reply
        /// </summary>
        /// <param name="ob">REPLYS</param>
        /// <returns>success or -1 fail</returns>
        public int Delete(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Replies.DeleteOnSubmit(ob as Reply);
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
        /// GetObject Reply
        /// </summary>
        /// <returns>list all reply</returns>
        public IQueryable<Object> GetObject()
        {
            IQueryable<Reply> listReply = DBChoose.GetDataContext().Replies;
            IQueryable<Object> list = (IQueryable<Object>)listReply;
            return list;
        }
        /// <summary>
        /// Getreply
        /// </summary>
        /// <param name="id">ReplyID</param>
        /// <returns>Reply</returns>
        public Reply GetReply(int id)
        {
            return (from m in (IQueryable<Reply>)GetObject() where m.ReplyID == id select m).FirstOrDefault();
        }
        #endregion



    }
}
