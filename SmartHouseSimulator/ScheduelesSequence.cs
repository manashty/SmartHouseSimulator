using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseSimulator
{
   public class ScheduelesSequence
    {
       public Schedule schedueleItem;
        public int daysDelayFromFirstScheduele;
        public int hoursDelayFromFirstScheduele;
        public int MinutesDelayFromFirstScheduele;
        public int secondsDelayFromFirstScheduele;

        public ScheduelesSequence()
        {
            schedueleItem = new Schedule();
        }
    }
}
