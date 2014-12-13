using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SmartHouseSimulator
{
    public class Sensor
    {
        public enum SensorDataFormat { Numeral, Point, MultiState }

        string[] multiStateLables;

        public string[] MultiStateLables
        {
            get { return multiStateLables; }
            set { multiStateLables = value; }
        }

        public string name;
        public SensorDataFormat dataFormat;
        private Object sensorData;

        public Object SensorData
        {
            get { return sensorData; }
            set {
                switch (dataFormat)
                {
                    case SensorDataFormat.Numeral:
                        SetState((float)value);
                        break;
                    case SensorDataFormat.Point:
                        SetState((Point)value);
                        break;
                    case SensorDataFormat.MultiState:
                        SetState((string)value);
                        break;
                    default:
                        SetState((string)value);
                        break;
                }
            }
        }


        public Sensor(String sensorName, SensorDataFormat sensorDataFormat)
        {
            name = sensorName;
            dataFormat = sensorDataFormat;                 
        }

        public Sensor(Sensor OldSensor)
        {
            name = OldSensor.name;
            dataFormat = OldSensor.dataFormat;
            multiStateLables = OldSensor.multiStateLables;
            sensorData = OldSensor.sensorData;
            //switch (dataFormat)
            //    {
            //        case SensorDataFormat.Numeral:
            //            sensorData= (float)sensorData;
            //            break;
            //        case SensorDataFormat.Point:
            //            sensorData= ((Point)sensorData);
            //            break;
            //        case SensorDataFormat.MultiState:
            //            // return "Sensor State is:" +multiStateLabales[(int)sensorData];
            //            sensorData = (string)sensorData;
            //            break;
            //        default:
            //            sensorData = OldSensor.sensorData;
            //            break;
            //    }
            //System.Windows.Forms.MessageBox.Show("Test");
            
        }
        public Sensor(String sensorName, SensorDataFormat sensorDataFormat, string[] multiStateLabels)
            : this(sensorName, sensorDataFormat)
        {
            multiStateLables = multiStateLabels;

        }

        public Sensor()
        {
            // TODO: Complete member initialization
        }


        public string GetStatus()
        {
            try
            {
                switch (dataFormat)
                {
                    case SensorDataFormat.Numeral:
                        return "Value is: " + (float)sensorData;
                        break;
                    case SensorDataFormat.Point:
                        return "Location is: " + ((Point)sensorData).ToString();
                        break;
                    case SensorDataFormat.MultiState:
                        // return "Sensor State is:" +multiStateLabales[(int)sensorData];
                        return "Sensor State is:" + (string)sensorData;
                        break;
                    default:
                        return "";
                        break;
                }
            }
            catch (Exception ex)
            {

                //throw;
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                //System.Windows.Forms.MessageBox.Show("Before getting the sensor values, please first set their value.");
                return "";
            }
        }
        public override string ToString()
        {
            return name + "(" + dataFormat.ToString() + ")";// GetStatus();
        }
        public void SetState(float Data)
        {
            sensorData = Data;
            SensorDataChanged(new KeyValuePair<string, string>(name, Data.ToString()), null);            
        }
        public void SetState(Point Data)
        {
            sensorData = Data;
            SensorDataChanged(new KeyValuePair<string, string>(name, Data.X + "_" + Data.Y), null);            
        }
        public void SetState(String Data)
        {
            sensorData = Data;

            SensorDataChanged(new KeyValuePair<string,string>(name, Data),null);            
        }

        public static event EventHandler SensorDataChanged;
        
    }
}
