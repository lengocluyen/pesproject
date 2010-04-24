using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PrimaryEducationSystem.Core.Database;
namespace PrimaryEducationSystem.Study
{
    // NOTE: If you change the class name "PESServices" here, you must also update the reference to "PESServices" in Web.config.
    public class PESServices : IPESServices
    {
        public void DoWork()
        {
        }
        #region LEARING

        #region Get Information Class
        PESDBDataContext pdb;
        public Class GetClassByID(int idClass)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from c in pdb.Classes where c.ClassID == idClass select c).FirstOrDefault();
            }
            catch { return null; }
        }
        public Class GetClassByName(string nameClass)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from c in pdb.Classes where c.ClassName == nameClass select c).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Class> GetAllClass()
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Classes select i).ToList();
            }
            catch { return null; }
        }

        #endregion

        #region Get Information Subject
        public Subject GetSubjectByID(int idSubject)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Subjects where idSubject == i.SubjectID select i).FirstOrDefault();
            }
            catch { return null; }
        }
        public Subject GetSubjectByName(string nameSubject)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Subjects where nameSubject == i.SubjectName select i).FirstOrDefault();
            }
            catch { return null; }
        }
        public List<Subject> GetAllSubject()
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Subjects select i).ToList();
            }
            catch { return null; }
        }
        public List<Subject> GetSubjectByClassID(int idClass)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Subjects where idClass == i.ClassID select i).ToList();
            }
            catch { return null; }
        }
        #endregion

        #region Get Information Part
        public Part GetPartByID(int idPart)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Parts where i.PartID == idPart select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public Part GetPartByName(string namePart)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Parts where i.PartName == namePart select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Part> GetPartBySubjectID(int idsubject)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Parts where i.SubjectID == idsubject select i).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Part> GetAllPart()
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Parts select i).ToList();
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Get Information Lesson
        public Lesson GetLessonByID(int idLesson)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Lessons where i.LessonID == idLesson select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public Lesson GetLessonByName(string nameLesson)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Lessons where i.LessonName == nameLesson select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Lesson> GetLessonByPartID(int idPart)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Lessons where i.PartID == idPart select i).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Lesson> GetLessonByPartname(string partname)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Lessons where i.PartID == GetPartByName(partname).PartID select i).ToList();
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Get Information Theory
        public Theory GetTheoryByID(int idTheory)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Theories where i.TheoryID == idTheory select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Theory> GetTheoryByLessonID(int idLesson)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Theories where i.LessonID == idLesson select i).ToList();
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Get Information Exercise
        public Exercise GetExerciseByID(int idExercise)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Exercises where i.ExerciseID == idExercise select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Exercise> GetExerciseByLessonID(int idLesson)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Exercises where i.LessonID == idLesson select i).ToList();
            }
            catch
            {
                return null;
            }
        }
        #endregion

        public User GetUserByID(Guid ID)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Users where i.UserID == ID select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public User GetUserByName(string name)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Users where i.UserName == name select i).FirstOrDefault();
            }
            catch 
            {
                return null;
            }
        }

        public User GetUserByEmail(string mail)
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Users where i.Email == mail select i).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public List<User> GetAllUser()
        {
            try
            {
                pdb = new PESDBDataContext();
                return (from i in pdb.Users select i).ToList();
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
