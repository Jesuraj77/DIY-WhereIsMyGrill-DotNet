using GrillBer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrillBer.BusinessLayer.Interfaces
{
   public interface IRenterServices
    {
        bool SignUp(Renter renter);
        bool SignIn(string rentername, string password);
        bool AddGrill(Grill grillber);
        Grill GetGrillsById(int grillid);
        bool UpdateGrill(Grill grillber);
        bool DeleteGrill(int grillId);


    }
}
