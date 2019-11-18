using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId,string firstname,
            string lastname, string emailAddress) 
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstname,
                LastName = lastname,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress)
                            values (@EmployeeId, @FirstName, @LastName, @EmailAddress);";
            
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select EmployeeId, FirstName, LastName, EmailAddress
                            from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
