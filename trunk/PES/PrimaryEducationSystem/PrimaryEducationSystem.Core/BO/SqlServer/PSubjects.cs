using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

namespace PrimaryEducationSystem.Core
{
    public class PSubjects:IDatafactory
    {
        public PSubjects()
        { }
        private static readonly PSubjects instance = new PSubjects();

        public static PSubjects Instance
        {
            get { return PSubjects.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// INSERT Subject
        /// </summary>
        /// <param name="ob">SUBJECT</param>
        /// <returns>1 success or -1 fail</returns>
        public int Insert(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().Subjects.InsertOnSubmit(ob as Subject);
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
        /// Update Subject
        /// </summary>
        /// <param name="ob">SUBJECT</param>
        /// <returns>1 success or -1 fail</returns>
        public int Update(object ob)
        {
            try
            {
                Subject subnew = ob as Subject;
                Subject subold = GetSubject(subnew.SubjectID);
                subold.SubjectID = subnew.SubjectID;
                subold.ClassID = subnew.ClassID;
                subold.SubjectName = subnew.SubjectName;
                subold.Description = subnew.Description;
                subold.MediaFile = subnew.MediaFile;
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
        /// Delete Subject
        /// </summary>
        /// <param name="ob">SUBJECT</param>
        /// <returns>1 success or -1 fail</returns>
        public int Delete(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().Subjects.DeleteOnSubmit(ob as Subject);
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
        /// GetObject Subject
        /// </summary>
        /// <returns>list all subjects</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<Subject> listSubject = DBChoose.GetDataContext().Subjects;
                IQueryable<Object> list = (IQueryable<Object>)listSubject;
                return list;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// GetSubject
        /// </summary>
        /// <param name="id">SubjectID</param>
        /// <returns>Subject</returns>
        public Subject GetSubject(int id)
        {
            return (from m in (IQueryable<Subject>)GetObject() where m.SubjectID == id select m).FirstOrDefault();
        }
        #endregion

    }
}
