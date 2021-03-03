using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IceBox
{
    class IceBox
    {
        protected bool isLampBurn;  //лампа
        protected bool isDoorOpen;  //
        protected int mode;
        protected int timer;
        protected bool work;
        private int maxMode;
        protected Thread threadWork;
        protected Object lockWork =new object();

        public delegate void WorkIceBox(object sender);
        public event WorkIceBox ChangeWork;

        /*public delegate void AccountHandler(string message);
        public event AccountHandler Notify;              // 1.Определение события*/

        public bool LampBurn { get => isLampBurn; }
        public bool DoorOpen { get => isDoorOpen;  }
        public int Mode { get => mode; private set => mode = value; }
        protected int Timer { get => timer; set => timer = value; }
        public bool Work { get => work; private set => work = value; }
        public Thread ThreadWork { get => threadWork; set => threadWork = value; }
        protected int MaxMode { get => maxMode; }

        public IceBox(int maxMode=5)
        {
            work = true;
            mode = 1;
            timer = 6;
            this.maxMode = maxMode;
            threadWork = new Thread(new ThreadStart(WorkingIceBox));
            threadWork.IsBackground = true;
            threadWork.Start();
        }


        protected void WorkingIceBox()
        {
            while (true)
            {
                Thread.Sleep(1000);
               
                lock (lockWork) {
                    timer--;
                    if (timer == 0)
                    {

                        work = !work;
                        ChangeWork?.Invoke(this);
                        if (work)
                        {
                            timer = mode * 6;
                        }
                        else
                        {
                            timer = 6;
                        }
                    }
                }
            }
        }

        public void OpenDoorIceBox()
        {
            isDoorOpen = true;
            isLampBurn = true;
        }

        public void CloseDoorIceBox()
        {
            isDoorOpen = false;
            isLampBurn = false;
        }

        public void ResetIceBox()
        {
            //threadWork.
            lock (lockWork)
            {
                timer = mode * 6;
                work = true;
                ChangeWork?.Invoke(this);
            }

        }

        public void UpMode()
        {
            if (!isDoorOpen) throw new Exception("Попытка переключить с закрытым холодильником");
            if (mode < maxMode) {

                mode++;
                ResetIceBox();
              
            }
        }

        public void DownMode()
        {
            if (!isDoorOpen) throw new Exception("Попытка переключить с закрытым холодильником");
            if (mode >0)
            {
                mode--;
                ResetIceBox();
               
            }
        }

        


    }
}
