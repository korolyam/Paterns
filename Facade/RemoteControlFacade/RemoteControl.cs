using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProject.RemoteControlFacade
{
    public class RemoteControl
    {
        public static void Use(DriverForRemoteControl driverForRemoteControl)
        {
            driverForRemoteControl.Operation();
        }
    }
}
