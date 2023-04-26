using Gaming_Center.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Center.Dao
{
    public class AccountDao
    {
        public Account GetAccount(string user, string pass)
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    return context.Accounts.FirstOrDefault(a => a.Username == user && a.Password == pass);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
