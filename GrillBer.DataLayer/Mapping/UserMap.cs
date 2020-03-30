using FluentNHibernate.Mapping;
using GrillBer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrillBer.DataLayer.Mapping
{

    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId);

            Map(x => x.UserName);

            Map(x => x.Phonenumber);
            Map(x => x.Email);
            Map(x => x.Password);
            Map(x => x.Address);
            Table("user");

        }
    }


}
