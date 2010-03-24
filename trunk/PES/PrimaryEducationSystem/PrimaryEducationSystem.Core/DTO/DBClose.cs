using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using PrimaryEducationSystem.Core.Database;

public class DBClose
{
    public static void SubmitHandle()
    {
        PESDBDataContext dt = DBChoose.GetDataContext();
        try
        {
            dt.SubmitChanges(ConflictMode.ContinueOnConflict);
        }
        catch
        {
            foreach (ObjectChangeConflict ob in dt.ChangeConflicts)
                ob.Resolve(RefreshMode.KeepCurrentValues);
            dt.SubmitChanges();
        }
    }
}
