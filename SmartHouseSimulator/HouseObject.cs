using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SmartHouseSimulator
{
    public class HouseObject
    {
        public String houseObjectName;
        public Image HouseObjectIcon;
        public Point itemPosition;
        public int itemIndex;
        public List<Sensor> sensors = new List<Sensor>();

        public HouseObject(Point ip, int id)
        {
            //sensors.Add(new Sensor("Light", Sensor.SensorDataFormat.MultiState, new string[] { "On", "Off", "Stand by" }));
            //sensors.Add(new Sensor("Temp", Sensor.SensorDataFormat.Numeral));
            //sensors.Add(new Sensor("Place", Sensor.SensorDataFormat.Point));
            //sensors.Add(new Sensor("Height", Sensor.SensorDataFormat.Numeral));
            itemPosition = ip;
            itemIndex = id;
            // sensors[0].
        }
        public HouseObject(String Name)
        {
            houseObjectName = Name;
        }

        public HouseObject(String Name, List<Sensor> ObjectSensors)
            : this(Name)
        {
            sensors = ObjectSensors;
        }

        public HouseObject(Point location, String Name, List<Sensor> ObjectSensors, int IconIndex)
            : this(Name)
        {
            sensors = ObjectSensors;
            itemPosition = location;
            itemIndex = IconIndex;
        }

        public HouseObject(String Name, List<Sensor> ObjectSensors, Image ObjectIcon)
            : this(Name, ObjectSensors)
        {
            HouseObjectIcon = ObjectIcon;
        }
        public HouseObject(String Name, List<Sensor> ObjectSensors, Image ObjectIcon, Point ip, int id)
            : this(Name, ObjectSensors, ObjectIcon)
        {
            itemPosition = ip;
            itemIndex = id;
        }
    }
}
