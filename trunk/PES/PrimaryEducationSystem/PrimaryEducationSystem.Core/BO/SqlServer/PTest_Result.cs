using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

namespace PrimaryEducationSystem.Core
{
    public class PTest_Result:IDatafactory
    {
        public PTest_Result()
        { }
        private static readonly PTest_Result instance = new PTest_Result();

        public static PTest_Result Instance
        {
            get { return PTest_Result.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// INSERT Test_Result
        /// </summary>
        /// <param name="ob">Test_Result</param>
        /// <returns>1 success or -1 fail</returns>
        public int Insert(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().TestResults.InsertOnSubmit(ob as TestResult);
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
        /// Update TEST_RESULTS
        /// </summary>
        /// <param name="ob">TEST_RESULTS</param>
        /// <returns>1 success or -1 fail</returns>
        public int Update(object ob)
        {
            try
            {
                TestResult testnew = ob as TestResult;
                TestResult testold = GetTest_Result(testnew.TestResultID);
                testold.UserID = testnew.UserID;
                testold.TestID = testnew.TestID;
                testold.Time = testnew.Time;
                testold.Date = testnew.Date;
                testold.Result = testnew.Result;
                testold.MediaFile = testnew.MediaFile;
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
        /// Delete TEST_RESULTS
        /// </summary>
        /// <param name="ob">TEST_RESULTS</param>
        /// <returns>1 success or -1 fail</returns>
        public int Delete(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().TestResults.DeleteOnSubmit(ob as TestResult);
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
        /// GetObject Test_Result
        /// </summary>
        /// <returns>list all TEST_RESULTS</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<TestResult> listTest = DBChoose.GetDataContext().TestResults;
                IQueryable<Object> list = (IQueryable<Object>)listTest;
                return list;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// GetTestResult
        /// </summary>
        /// <param name="id">TestResultID</param>
        /// <returns>TEST_RESULTS</returns>
        public TestResult GetTest_Result(int id)
        {
            return (from m in (IQueryable<TestResult>)GetObject() where m.TestResultID == id select m).FirstOrDefault();
        }
        #endregion
    }
}
