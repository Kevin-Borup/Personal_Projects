using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempProject
{
    class Manager
    {
        Logic myLogic = new Logic();
        Logic1 logic1 = new Logic1();

        public void mgaTest()
        {
            myLogic.Test();
        }
        public int mgaSum()
        {
            return logic1.Sum();
        }
    }
}
