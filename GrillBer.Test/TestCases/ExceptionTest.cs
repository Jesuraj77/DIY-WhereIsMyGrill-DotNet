using GrillBer.BusinessLayer.Services;
using GrillBer.DataLayer;
using GrillBer.Entities;
using GrillBer.Test.Execptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GrillBer.Test
{
   public class ExceptionTest
    {

        private readonly UserServices _Userservice;
        private readonly RenterServices _Renatalservices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _Userservice = new UserServices(_session);
            _Renatalservices = new RenterServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_GrillNotFound()
        {
            Grill grill = new Grill()
            {
              GrillId=1,
              RenterId=1,
              FromDate=DateTime.Now,
              ToDate=DateTime.Now,
            };

            //Assert
            var ex = Assert.Throws<GrillNotFoundException>(() => _Userservice.CheckAvailability(grill.GrillId,grill.RenterId,grill.FromDate,grill.ToDate));
            Assert.Equal("Grill Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFound()
        {
            User user = new User()
            {
                UserName = "aaa",
                Password = "1234"
            };

            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _Userservice.SignIn(user.UserName, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }
    }
}
