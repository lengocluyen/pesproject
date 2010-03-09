using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;
namespace PrimaryEducationSystem.Core
{
    public class PGameResults:IDatafactory
    {
        private static readonly PGameCategory instance = new PGameCategory();

        public static PGameCategory Instance
        {
            get { return PGameResults.instance; }
        }
        #region Insert, Update, Delete
        /// <summary>
        /// GameResult Insert
        /// </summary>
        /// <param name="ob">GAME_RESULTS</param>
        /// <returns>1 success or -1 fail</returns>
        public int Insert(object ob)
        {
            try
            {
                DBChoose.GetDataContext().GameResults.InsertOnSubmit(ob as GameResult);
                DBClose.SubmitHandle();
                return 1;
            }
            catch 
            {
                return -1;
            }
        }
        /// <summary>
        /// GameResult Update
        /// </summary>
        /// <param name="ob">GAME_RESULTS</param>
        /// <returns>1 success or -1 fail</returns>
        public int Update(object ob)
        {
            try
            {
                GameResult gnew = ob as GameResult;
                GameResult gold = GetGameResult(gnew.GameResultID);
                gold.GameScores = gnew.GameScores;
                gold.GameType = gnew.GameType;
                DBClose.SubmitHandle();
                return 1;
            }
            catch 
            {
                return -1;   
            }
        }
        /// <summary>
        /// GameResult Delete
        /// </summary>
        /// <param name="ob">GAME_RESULTS</param>
        /// <returns>1 success or -1 fail</returns>
        public int Delete(object ob)
        {
            try
            {
                DBChoose.GetDataContext().GameResults.DeleteOnSubmit(ob as GameResult);
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
        /// Get All GameResult
        /// </summary>
        /// <returns>GAME_RESULTS success or null fail</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<GameResult> listGameResult = DBChoose.GetDataContext().GameResults;
                IQueryable<Object> list = (IQueryable<Object>)listGameResult;
                return list;
            }
            catch 
            {
                return null;   
            }
            
        }
        /// <summary>
        /// Get GameResult
        /// </summary>
        /// <param name="id">GameResulID</param>
        /// <returns>GAME_RESULT success or null fail</returns>
        public GameResult GetGameResult(int id)
        {
            try
            {
                return (from m in (IQueryable<GameResult>)GetObject() where m.GameResultID == id select m).FirstOrDefault();
            }
            catch 
            {
                return null;
            }
        }
        #endregion

    }
}
