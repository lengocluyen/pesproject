using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;
namespace PrimaryEducationSystem.Core
{
    public class PGames:IDatafactory
    {
        private static readonly PGames instance = new PGames();

        public static PGames Instance
        {
            get { return PGames.instance; }
        }

        #region Insert, Update, Delete
        /// <summary>
        /// Game Insert
        /// </summary>
        /// <param name="ob">GAMES</param>
        /// <returns>1 success or -1 fail</returns>
        public int Insert(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Games.InsertOnSubmit(ob as Game);
                DBClose.SubmitHandle();
                return 1;
            }
            catch 
            {
                return -1;
            }
        }
        /// <summary>
        /// Game Update
        /// </summary>
        /// <param name="ob">GAMES</param>
        /// <returns>1 success or -1 fail</returns>
        public int Update(object ob)
        {
            try
            {
                Game gnew = ob as Game;
                Game gold = GetGame(gnew.GameID);
                gold.GameName = gnew.GameName;
                gold.GameType = gnew.GameType;
                gold.Help = gnew.Help;
                return 1;
            }
            catch 
            {
                return -1;
            }
        }
        /// <summary>
        /// Game Delete
        /// </summary>
        /// <param name="ob">GAMES</param>
        /// <returns>1 success or -1 fail</returns>
        public int Delete(object ob)
        {
            try
            {
                DBChoose.GetDataContext().Games.DeleteOnSubmit(ob as Game);
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
        /// Games Get all 
        /// </summary>
        /// <returns>GAMES</returns>
        public IQueryable<Object> GetObject()
        {
            try
            {
                IQueryable<Game> listGames = DBChoose.GetDataContext().Games;
                IQueryable<Object> list = (IQueryable<Object>)listGames;
                return list;
            }
            catch 
            {
                return null;            
            }
        }
        /// <summary>
        /// Game get
        /// </summary>
        /// <param name="id">GameID (int)</param>
        /// <returns>GAME</returns>
        public Game GetGame(int id)
        {
            try
            {
                return (from m in (IQueryable<Game>)GetObject() where m.GameID == id select m).FirstOrDefault();
            }
            catch 
            {
                return null;   
            }
        }
        #endregion

    }
}
