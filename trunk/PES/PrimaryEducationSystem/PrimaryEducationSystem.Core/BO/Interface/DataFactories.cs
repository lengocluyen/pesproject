using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimaryEducationSystem.Core
{
    public class DataFactories
    {
        /// <summary>
        /// Get type
        /// </summary>
        /// <param name="dataType">Data type ()</param>
        /// <returns></returns>
        public static IDatafactory GetType(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.eArtice:
                    return PArticles.Instance;

                case DataType.eClass:
                    return PClass.Instance;

                case DataType.eExercise:
                    return PExercises.Instance;

                case DataType.eGameCategory:
                    return PGameCategory.Instance;

                case DataType.eGameResul:
                    return PGameResults.Instance;

                case DataType.eGame:
                    return PGames.Instance;

                case DataType.eLesson:
                    return PLessons.Instance;

                case DataType.eLogs:
                    return PLogs.Instance;

                case DataType.eMailBox:
                    return PMailBox.Instance;

                case DataType.ePart:
                    return PParts.Instance;

                case DataType.eQuestion:
                    return PQuestions.Instance;

                case DataType.eReply:
                    return PReply.Instance;

                case DataType.eRole:
                    return PRole.Instance;

                case DataType.eSubject:
                    return PSubjects.Instance;
                
                case DataType.eTest:
                    return PTest.Instance;

                case DataType.eTestResult:
                    return PTest_Result.Instance;

                case DataType.eTheory:
                    return PTheories.Instance;

                case DataType.eUser:
                    return PUser.Instance;

                case DataType.eUserGroup:
                    return PUser_Group.Instance;
            }
            return null;
        }
    }
    /// <summary>
    /// To enumrable
    /// </summary>
    public enum DataType
    {
        eArtice,
        eClass,
        eExercise,
        eGameCategory,
        eGameResul,
        eGame,
        eLesson,
        eLogs,
        eMailBox,
        ePart,
        eQuestion,
        eReply,
        eRole,
        eSubject,
        eTest,
        eTestResult,
        eTheory,
        eUser,
        eUserGroup
    }
}