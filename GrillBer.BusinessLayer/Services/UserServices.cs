using GrillBer.BusinessLayer.Interfaces;
using GrillBer.DataLayer;
using GrillBer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrillBer.BusinessLayer.Services
{
    public class UserServices : IUserServices
    {

        private readonly IMapperSession _session;

        public UserServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool Bookgrill(DateTime FromTime, DateTime ToTime, int UserId, string GrillType)
        {
            return true;
        }

        public bool CheckAvailability(int Grillid, int RenterId, DateTime FromDate,DateTime ToDate)
        {
            return true;
        }

        public bool DeleteUser(int userid)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int userid)
        {
            throw new NotImplementedException();
        }

        public bool Payment(int UserId, int RenterId)
        {
            return true;
        }

        public bool SignIn(string username, string password)
        {
            return true;
        }

        public bool SignUp(User user)
        {
            return true;
        }

        public bool UpdateUser(int userid)
        {
            throw new NotImplementedException();
        }
    }
}
