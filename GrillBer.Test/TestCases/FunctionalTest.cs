using GrillBer.BusinessLayer.Services;
using GrillBer.DataLayer;
using GrillBer.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GrillBer.Test
{
    public class FunctionalTest
    {
        private readonly UserServices _Userservice;
        private readonly RenterServices _Renatalservices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _Userservice = new UserServices(_session);
            _Renatalservices = new RenterServices(_session);
        }

        [Fact]
        public void Test_for_SignUp()
        {
            User user = new User()
            {
                UserId = 1,
                UserName = "aaa",
                Email = "aa@gmail.com",
                Password = "1234"
            };
            var SignUp = _Userservice.SignUp(user);
            Assert.True(SignUp);
        }

        [Fact]
        public void Test_for_SignIn()
        {
            User user = new User()
            {
                UserName = "aaa",
                Password = "1234"
            };
            var SignIn = _Userservice.SignIn(user.UserName, user.Password);
            Assert.True(SignIn);
        }

        User user = new User
        {
            UserId = 1,
            UserName = "abc",
            Phonenumber = 9889768540,
            Email = "Example@gmail.com",
            Password = "1234",
            Address = "Bangalore"
        };


        Grill grill = new Grill
        {
            GrillId = 1,
            GrillType = "Gas",
            FromDate = DateTime.Now,
            ToDate =DateTime.Now,
            UserId=1,
        };


        [Fact]
        public void TestForAddUser()
        {
            //Action
            var IsAdded = _Userservice.AddUser(user);
            //Assert
            Assert.True(IsAdded);
        }



        [Fact]
        public void TestForUpdateuser()
        {
            //Action
            var getuser = _Userservice.GetUserById(user.UserId);
            var updateduser = _Userservice.UpdateUser(user.UserId);
            //Assert
            Assert.True(updateduser);
        }


        [Fact]
        public void TestForDeleteuser()
        {
            //Action
            var deleteduser = _Userservice.DeleteUser(user.UserId);
            //Assert
            Assert.True(deleteduser);
        }


        [Fact]
        public void TestForBookGrill()
        {
            
            //Action
            var Bookgrill = _Userservice.Bookgrill(grill.FromDate,grill.ToDate, user.UserId,grill.GrillType);
            //Assert
            Assert.True(Bookgrill);
        }


        [Fact]
        public void TestForAddGrill()
        {
            //Action
            var IsAdded = _Renatalservices.AddGrill(grill);
            //Assert
            Assert.True(IsAdded);
        }



        [Fact]
        public void TestForUpdateGrill()
        {
            //Action
            var getuser = _Renatalservices.GetGrillsById(grill.GrillId);
            var updatedgrill = _Renatalservices.UpdateGrill(grill);
            //Assert
            Assert.True(updatedgrill);
        }


        [Fact]
        public void TestForDeletegrill()
        {
            //Action
            var deletedgrill = _Renatalservices.DeleteGrill(grill.GrillId);
            //Assert
            Assert.True(deletedgrill);
        }


    }

}
