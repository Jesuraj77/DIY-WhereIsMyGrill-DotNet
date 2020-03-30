using System;
using System.Collections.Generic;
using System.Text;

namespace GrillBer.Test.Execptions
{
    public class GrillNotFoundException:Exception
    {
        public string Messages = "Grill Not Found";

        public GrillNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
