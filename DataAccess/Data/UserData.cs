using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class UserData
{
    private readonly ISqlDataAccess _db;
 

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<UserModel>> GetUser() => _db.LoadData<UserModel, dynamic>(storedProcedure: "dbo.spUser_GetAll", new {});
}
