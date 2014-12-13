using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouseSimulator
{
   public class Scenario
    {
       public  string scenarioName;
       public DateTime scenarioDate;
       public DateTime scenarioTime;
       public float scenarioRepeatTime;


       public List<Condition> scenarioConditions=new List<Condition>();


      public List<ScheduelesSequence> scheduelesSet = new List<ScheduelesSequence>();
      }
}
