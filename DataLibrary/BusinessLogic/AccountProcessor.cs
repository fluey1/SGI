using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class AccountProcessor
    {
        public static int CreateAccount(int accountId, string name,
            string street, string city,
            string stateProvince, string country)
        {
            AccountModel data = new AccountModel
            {
                AccountId = accountId,
                Name = name,
                Street = street,
                City = city,
                StateProvince = stateProvince, 
                Country = country
            };

            string sql = @"insert into dbo.Account (AccountId, Name, Street, City, StateProvince, Country)
                            values (@AccountId, @Name, @Street, @City, @StateProvince, @Country);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<AccountModel> LoadAccounts()
        {
            string sql = @"select * from dbo.Account";

            return SqlDataAccess.LoadData<AccountModel>(sql);
        }
    }
}
