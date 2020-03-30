using GrillBer.BusinessLayer.Interfaces;
using GrillBer.DataLayer;
using GrillBer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrillBer.BusinessLayer.Services
{
    public class RenterServices : IRenterServices
    {

        private readonly IMapperSession _session;

        public RenterServices(IMapperSession session)
        {
            _session = session;
        }
        public bool AddGrill(Grill grillber)
        {
            return true;
        }

        public bool DeleteGrill(int grillId)
        {
            return true; 
        }

        public Grill GetGrillsById(int grillid)
        {
            Grill grill = new Grill();
            return grill;
        }

        public bool SignIn(string rentername, string password)
        {
            return true;
        }

        public bool SignUp(Renter renter)
        {
            return true;
        }

        public bool UpdateGrill(Grill grillber)
        {
            return true;
        }
    }
}
