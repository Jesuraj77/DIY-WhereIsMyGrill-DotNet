using System;
using System.Collections.Generic;
using System.Text;

namespace GrillBer.Test.Execptions
{
   public class UserNotFoundException:Exception
    {
        public string Messages = "Grill Not Found";

        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
