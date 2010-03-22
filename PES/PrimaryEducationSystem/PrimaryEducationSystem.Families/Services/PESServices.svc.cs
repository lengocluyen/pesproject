using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PrimaryEducationSystem.Core.Database;
using System.Configuration;
namespace PrimaryEducationSystem.Families.Services
{
    // NOTE: If you change the class name "PESServices" here, you must also update the reference to "PESServices" in Web.config.
    public class PESServices : IPESServices
    { 
        #region LEARING
        #region Get Information Class
        public Class GetClassByID(int idClass);
        public Class GetClassByName(string nameClass);
        public List<Class> GetAllClass();
        #endregion
        #region Get Information Subject
        public Subject GetSubjectByID(int idSubject);
        public Subject GetSubjectByName(string nameSubject);
        public List<Subject> GetAllSubject();
        public List<Subject> GetSubjectByClassID(int idClass);
        #endregion
        #region Get Information Part
        public Part GetPartByID(int idPart);
        public Part GetPartByName(string namePart);
        public List<Part> GetPartBySubjectID(int idsubject);
        public List<Part> GetAllPart();
        #endregion
        #region Get Information Lesson
        public Lesson GetLessonByID(int idLesson);
        public Lesson GetLessonByName(string nameLesson);
        public List<Lesson> GetLessonByPartID(int idPart);
        #endregion
        #region Get Information Theory
        public Theory GetTheoryByID(int idTheory);
        public List<Theory> GetTheoryByLessonID(int idLesson);
        #endregion
        #region Get Information Exercise
        public Exercise GetExerciseByID(int idExercise);
        public List<Exercise> GetExerciseByLessonID(int idLesson);
        #endregion
        #endregion
    }
}
