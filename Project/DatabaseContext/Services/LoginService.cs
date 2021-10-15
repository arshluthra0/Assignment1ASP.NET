using Microsoft.EntityFrameworkCore;
using Project.DatabaseContext.Tables;
using Project.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Project.DatabaseContext.Services
{
    public class LoginService
    {
        DbEntity db;
        public LoginService()
        {
            db = new DbEntity();
        }

        /// <summary>
        /// Checking Login Information
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public async Task<MasterModel<LoginTbl>> LoginAccountAsync(string username, string password)
        {
            try
            {
                var userDetail = await db.loginTbls.Where(x => x.Username == username && x.Password == password).SingleOrDefaultAsync();
                if (userDetail == null)
                {
                    return new MasterModel<LoginTbl>
                    {
                        Status = false,
                        Errors = new string[] { "Username and password incorrect" }
                    };
                }
                if (string.IsNullOrEmpty(userDetail.Id))
                {
                    return new MasterModel<LoginTbl>
                    {
                        Status = false,
                        Errors = new string[] { "Username and password incorrect" }
                    };
                }
                return new MasterModel<LoginTbl>
                {
                    Status = true,
                    Result = userDetail
                };
            }
            catch (Exception ex)
            {
                return new MasterModel<LoginTbl>
                {
                    Status = false,
                    Errors = new string[] { ex.Message }
                };
            }
        }
    }
}
