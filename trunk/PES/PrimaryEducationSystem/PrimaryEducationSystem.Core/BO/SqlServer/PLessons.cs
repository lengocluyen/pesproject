using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;
namespace PrimaryEducationSystem.Core
{
    public class PLessons:IDatafactory
    {
        private static readonly PLessons instance = new PLessons();

        public static PLessons Instance
        {
            get { return PLessons.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// Lesson Insert
        /// </summary>
        /// <param name="ob">LESSONS</param>
        /// <returns>1 (success) or -1 (fail)</returns>
        public int Insert(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Lessons.InsertOnSubmit(ob as Lesson);
                DBClose.SubmitHandle();
                return 1;
            }
            catch 
            {
                return -1;
            }
        }
        /// <summary>
        /// Lesson Update
        /// </summary>
        /// <param name="ob">LESSONS</param>
        /// <returns>1 (success) or -1 (fail)</returns>
        public int Update(object ob)
        {
            try
            {
                Lesson lsnew = ob as Lesson;
                Lesson lsold = GetLesson(lsnew.LessonID);
                lsold.PartID = lsnew.PartID;
                lsold.LessonName = lsnew.LessonName;
                lsold.Description = lsnew.Description;
                DBClose.SubmitHandle();
                return 1;
            }
            catch 
            {
                return -1;
            }
        }
        /// <summary>
        /// Lesson Delete
        /// </summary>
        /// <param name="ob">LESSONS</param>
        /// <returns>1 (success) or -1 (fail)</returns>
        public int Delete(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Lessons.DeleteOnSubmit(ob as Lesson);
                DBClose.SubmitHandle();
                return 1;
            }
            catch 
            {
                return -1;   
            }
        }
        #endregion

        #region Ultility
        /// <summary>
        /// Get all Lessons
        /// </summary>
        /// <returns>LESSONS (success) or null (fail)</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<Lesson> lessonList = DBChoose.GetDataContext().Lessons;
                IQueryable<Object> list = (IQueryable<Object>)lessonList;
                return list;
            }
            catch 
            {
                return null;
            }
        }
        /// <summary>
        /// Get Lessons
        /// </summary>
        /// <param name="id">LessonID</param>
        /// <returns>LESSON success null fail</returns>
        public Lesson GetLesson(int id)
        {
            try
            {
                return (from m in (IQueryable<Lesson>)GetObject() where m.LessonID == id select m).FirstOrDefault();
            }
            catch 
            {
                return null;
            }
        }
        #endregion

    }
}
