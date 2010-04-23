using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PrimaryEducationSystem.Core.Database;
namespace PrimaryEducationSystem.Study
{
    // NOTE: If you change the interface name "IPESServices" here, you must also update the reference to "IPESServices" in Web.config.
    [ServiceContract]
    public interface IPESServices
    {
        [OperationContract]
        void DoWork();
        #region LEARING

        #region Get Information Class
        [OperationContract]
        Class GetClassByID(int idClass);
        [OperationContract]
        Class GetClassByName(string nameClass);
        [OperationContract]
        List<Class> GetAllClass();
        #endregion

        #region Get Information Subject
        [OperationContract]
        Subject GetSubjectByID(int idSubject);
        [OperationContract]
        Subject GetSubjectByName(string nameSubject);
        [OperationContract]
        List<Subject> GetAllSubject();
        [OperationContract]
        List<Subject> GetSubjectByClassID(int idClass);
        #endregion

        #region Get Information Part
        [OperationContract]
        Part GetPartByID(int idPart);
        [OperationContract]
        Part GetPartByName(string namePart);
        List<Part> GetPartBySubjectID(int idsubject);
        [OperationContract]
        List<Part> GetAllPart();
        #endregion

        #region Get Information Lesson
        [OperationContract]
        Lesson GetLessonByID(int idLesson);
        [OperationContract]
        Lesson GetLessonByName(string nameLesson);
        [OperationContract]
        List<Lesson> GetLessonByPartID(int idPart);
        #endregion

        #region Get Information Theory
        [OperationContract]
        Theory GetTheoryByID(int idTheory);
        [OperationContract]
        List<Theory> GetTheoryByLessonID(int idLesson);
        #endregion

        #region Get Information Exercise
        [OperationContract]
        Exercise GetExerciseByID(int idExercise);
        [OperationContract]
        List<Exercise> GetExerciseByLessonID(int idLesson);
        #endregion

        [OperationContract]
        User GetUserByID(Guid ID);
        [OperationContract]
        User GetUserByEmail(string email);
        [OperationContract]
        User GetUserByName(string name);
        [OperationContract]
        List<User> GetAllUser();
        #endregion
    }
}
