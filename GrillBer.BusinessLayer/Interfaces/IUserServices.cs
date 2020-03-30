using GrillBer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrillBer.BusinessLayer.Interfaces
{
   public interface IUserServices
    {
        bool SignUp(User user);
        bool SignIn(string username, string password);
        bool Bookgrill(DateTime FromTime, DateTime ToTime, int UserId, string GrillType);
        bool CheckAvailability(int Grillid, int RenterId, DateTime FromDate,DateTime ToDate);
        bool Payment(int UserId, int RenterId);
        bool AddUser(User user);
        User GetUserById(int userid);
        bool UpdateUser(int userid);
        bool DeleteUser(int userid);


    }
}
