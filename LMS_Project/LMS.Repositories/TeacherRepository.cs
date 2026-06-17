using Dapper;
using LMS.Entities; 
using Microsoft.Data.SqlClient; 
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Repositories;

public class TeacherRepository
{
    private readonly string _connectionString = "Server=.;Database=LMS_DB;Trusted_Connection=True;TrustServerCertificate=True;";

    public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
    {
        using IDbConnection db = new SqlConnection(_connectionString);

        
        return await db.QueryAsync<Teacher>(
            "sp_GetAllTeachers",
            commandType: CommandType.StoredProcedure);
    }

}
