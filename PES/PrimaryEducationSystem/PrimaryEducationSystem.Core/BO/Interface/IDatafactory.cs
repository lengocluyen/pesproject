using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimaryEducationSystem.Core.Database;

public interface IDatafactory
{
    #region insert update delete
    int Insert(Object ob);
    int Update(Object ob);
    int Delete(Object ob);
    #endregion

    #region Get
    IQueryable<Object> GetObject();
    #endregion
}
