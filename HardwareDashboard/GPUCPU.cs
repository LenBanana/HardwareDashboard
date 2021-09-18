using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareDashboard
{
    class GPUCPU
    {
        public class CPU
        {
            public string Name { get; set; }

            public List<float?> loadCores = new List<float?>();
            public float? loadTotal { get; set; }
            public float? Temp { get; set; }
        }

        public class GPU
        {
            public string Name { get; set; }
            public float? Load { get; set; }
            public float? Temp { get; set; }
        }

        public static async Task<(CPU, GPU)> GetLoad(Computer comp)
        {
            return await Task<(CPU, GPU)>.Run(() =>
            {
                CPU CPUresult = new CPU();
                comp.CPUEnabled = true;
                comp.GPUEnabled = false;
                comp.RAMEnabled = false;
                comp.HDDEnabled = false;
                foreach (var hardware in comp.Hardware)
                {
                    hardware.Update();
                    CPUresult.Name = hardware.Name;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            if (sensor.Name != "CPU Total")
                                CPUresult.loadCores.Add(sensor.Value);
                            else
                                CPUresult.loadTotal = sensor.Value;
                        }
                        if (sensor.SensorType == SensorType.Temperature)
                            CPUresult.Temp = sensor.Value;
                    }
                }

                GPU GPUresult = new GPU();
                comp.GPUEnabled = true;
                comp.CPUEnabled = false;
                comp.RAMEnabled = false;
                comp.HDDEnabled = false;
                foreach (var hardware in comp.Hardware)
                {
                    hardware.Update();
                    GPUresult.Name = hardware.Name;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                            GPUresult.Load = sensor.Value;
                        if (sensor.SensorType == SensorType.Temperature)
                            GPUresult.Temp = sensor.Value;
                    }
                }
                return (CPUresult, GPUresult);
            });
        }
    }
}
