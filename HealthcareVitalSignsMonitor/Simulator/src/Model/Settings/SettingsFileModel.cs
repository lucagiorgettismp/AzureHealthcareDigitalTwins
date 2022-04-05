using Simulator.Model.Settings;
using System;
using System.Collections.Generic;

namespace Simulator.src.Model.Settings
{
    public class SettingsFileModel
    {
        public List<DeviceSettings> Devices { get; set; }

        internal DeviceSettings GetDeviceSettingsByDeviceId(string deviceId)
        {
            foreach (var device in Devices)
            {
                if (device.DeviceId == deviceId)
                {
                    return device;
                }
            }

            return null;
        }
    }
}
