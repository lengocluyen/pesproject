using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public class PExercises : IDatafactory
{
    private static readonly PExercises instance = new PExercises();

    public static PExercises Instance
    {
        get { return PExercises.instance; }
    }

    #region Insert, Update, Delete
    /// <summary>
    /// Exercise Insert
    /// </summary>
    /// <param name="ob">EXERCISES</param>
    /// <returns>1 success or -1 fail</returns>
    public int Insert(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Exercises.InsertOnSubmit(ob as Exercise);
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            return -1;
        }
    }
    /// <summary>
    /// Exercise Update
    /// </summary>
    /// <param name="ob">EXERCISES</param>
    /// <returns>1 success or -1 fail</returns>
    public int Update(object ob)
    {
        try
        {
            Exercise exnew = ob as Exercise;
            Exercise exold = GetExercise(exnew.ExerciseID);
            exold.LessonID = exnew.LessonID;
            exold.Contents = exnew.Contents;
            exold.Result = exnew.Result;
            exold.MediaFile = exnew.MediaFile;
            DBClose.SubmitHandle();
            return 1;
        }
        catch
        {
            return -1;
        }
    }
    /// <summary>
    /// Exercise Delete
    /// </summary>
    /// <param name="ob">EXERCISES</param>
    /// <returns>1 success or -1 fail</returns>
    public int Delete(object ob)
    {
        try
        {
            DBChoose.GetDataContext().Exercises.DeleteOnSubmit(ob as Exercise);
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
    /// Exercise GetAll
    /// </summary>
    /// <returns>EXERCISES</returns>
    public IQueryable<Object> GetObject()
    {

        IQueryable<Exercise> listexercise = DBChoose.GetDataContext().Exercises;
        IQueryable<Object> list = (IQueryable<Object>)listexercise;
        return list;

    }
    /// <summary>
    /// Exercise GetLog
    /// </summary>
    /// <param name="id">EXERCISES</param>
    /// <returns>EXERCISE</returns>
    public Exercise GetExercise(int id)
    {
        return (from m in (IQueryable<Exercise>)GetObject() where m.ExerciseID == id select m).SingleOrDefault();
    }
    #endregion
}
