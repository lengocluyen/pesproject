using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

namespace PrimaryEducationSystem.Core
{
    public class PQuestions:IDatafactory
    {
        public PQuestions()
        { }
        private static readonly PQuestions instance = new PQuestions();

        public static PQuestions Instance
        {
            get { return PQuestions.instance; }
        }
        #region Insert, Delete, Update
        /// <summary>
        /// Insert Questions
        /// </summary>
        /// <param name="ob">QUESTIONS</param>
        /// <returns>1 success or -1 fail</returns>
        public int Insert(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().Questions.InsertOnSubmit(ob as Question);
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
        /// Update Questions
        /// </summary>
        /// <param name="ob">QUESTIONS</param>
        /// <returns>1 success or -1 fail</returns>
        public int Update(object ob)
        {
            try
            {
                Question quesnew = ob as Question;
                Question quesold = GetQuestions(quesnew.QuestionID);
                quesold.TestID = quesnew.TestID;
                quesold.Answer = quesnew.Answer;
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
        /// Delete Questions 
        /// </summary>
        /// <param name="ob">QUESTIONS</param>
        /// <returns> 1 success or -1 fail</returns>
        public int Delete(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Questions.DeleteOnSubmit(ob as Question);
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
        /// GetObject Questions
        /// </summary>
        /// <returns>list all Questions</returns>
        public IQueryable<Object> GetObject()
        {
            IQueryable<Question> listQuestions= DBChoose.GetDataContext().Questions;
            IQueryable<Object> list = (IQueryable<Object>)listQuestions;
            return list;
        }
        /// <summary>
        /// GetQuestions Questions
        /// </summary>
        /// <param name="id">QuestionID</param>
        /// <returns>Question</returns>
        public Question GetQuestions(int id)
        {
            return (from m in (IQueryable<Question>)GetObject() where m.QuestionID == id select m).FirstOrDefault();
        }

        #endregion


    }
}
