using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IceBox
{
    class IceBoxAddFreezer : IceBox
    {
        private IceBox freezer;

        public bool LampBurnFreezer { get => freezer.LampBurn; }
        public bool DoorOpenFreezer { get => freezer.DoorOpen; }
        public int ModeFreezer { get => freezer.Mode;  }
        public bool WorkFreezer { get => freezer.Work; }
        


        public IceBoxAddFreezer(int modeIceBox=5, int modeFreezer=3):base(modeIceBox)
        {
            
            freezer = new IceBox(modeFreezer);
             
        }

        public void OpenDoorFreezer()
        {
            freezer.OpenDoorIceBox();
        }

        public void CloseDoorFreezer()
        {
            freezer.CloseDoorIceBox();
        }

        public void UpModeFreezer()
        {
            freezer.UpMode();
        }

        public void DownModeFreezer()
        {
            freezer.DownMode();
        }

        public void AddReaction(WorkIceBox o)
        {
            freezer.ChangeWork += o;
        }

    }
}
