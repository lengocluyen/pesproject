using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

namespace PrimaryEducationSystem.Core
{
    public class PTest:IDatafactory
    {
        public PTest()
        { }
        private static readonly PTest instance = new PTest();

        public static PTest Instance
        {
            get { return PTest.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// INSERT Test
        /// </summary>
        /// <param name="ob">TEST</param>
        /// <returns>1 success or -1 fail</returns>
        public int Insert(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().Tests.InsertOnSubmit(ob as Test);
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
        /// Update Test
        /// </summary>
        /// <param name="ob">TEST</param>
        /// <returns>1 success or -1 fail</returns>
        public int Update(object ob)
        {
            try
            {
                Test testnew = ob as Test;
                Test testold = GetTest(testnew.TestID);
                testold.PartID = testnew.PartID;
                testold.TestName = testnew.TestName;
                testold._Level = testnew._Level;
                testold.Quantity = testnew.Quantity;
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
        /// Delete Test
        /// </summary>
        /// <param name="ob">TEST</param>
        /// <returns>1 success or -1 fail</returns>
        public int Delete(Object ob)
        {
            try
            {
                DBChoose.GetDataContext().Tests.DeleteOnSubmit(ob as Test);
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
        /// GetObject Test
        /// </summary>
        /// <returns>list all Test</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<Test> listTest = DBChoose.GetDataContext().Tests;
                IQueryable<Object> list = (IQueryable<Object>)listTest;
                return list;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// GetTest
        /// </summary>
        /// <param name="id">TestID</param>
        /// <returns>Test</returns>
        public Test GetTest(int id)
        {
            return (from m in (IQueryable<Test>)GetObject() where m.TestID == id select m).FirstOrDefault();
        }
        #endregion


    }
}
