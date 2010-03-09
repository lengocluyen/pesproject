using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;
namespace PrimaryEducationSystem.Core
{
    public class PParts: IDatafactory
    {
        private static readonly PParts instance = new PParts();

        public static PParts Instance
        {
            get { return PParts.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// Part Insert
        /// </summary>
        /// <param name="ob">PARTS</param>
        /// <returns>1(success) or -1(fail)</returns>
        public int Insert(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Parts.InsertOnSubmit(ob as Part);
                DBClose.SubmitHandle();
                return 1;
            }
            catch 
            {
                return -1;   
            }
        }
        /// <summary>
        /// Part Update
        /// </summary>
        /// <param name="ob">PARTS</param>
        /// <returns>1(success) or -1(fail)</returns>
        public int Update(object ob)
        {
            try
            {
                Part pnew = ob as Part;
                Part pold = GetParts(pnew.PartID);
                pold.SubjectID = pnew.SubjectID;
                pold.PartName = pnew.PartName;
                pold.Description = pnew.Description;
                return 1;
            }
            catch 
            {
                return -1;
            }
        }
        /// <summary>
        /// Part Delete
        /// </summary>
        /// <param name="ob">PARTS</param>
        /// <returns>1(success) or -1(fail)</returns>
        public int Delete(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Parts.DeleteOnSubmit(ob as Part);
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
        /// Part get
        /// </summary>
        /// <param name="p">PartID</param>
        /// <returns>PART</returns>
        public Part GetParts(int p)
        {
            try
            {
                return (from m in (IQueryable<Part>)GetObject() where m.PartID == p select m).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Parts Get all 
        /// </summary>
        /// <returns>PARTS</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<Part> pastList = DBChoose.GetDataContext().Parts;
                IQueryable<Object> list = (IQueryable<Object>)pastList;
                return list;
            }
            catch 
            {
                return null;   
            }
        }
        #endregion

    }
}
