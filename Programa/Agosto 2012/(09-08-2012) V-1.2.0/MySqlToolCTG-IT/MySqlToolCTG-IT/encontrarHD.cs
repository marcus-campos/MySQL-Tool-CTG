using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace MySqlToolCTG_IT
{
    class encontrarHD
    {
        public string serialHD(string _HD)
        {
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + _HD + "");
            disk.Get();
            string serial = disk["VolumeSerialNumber"].ToString();
            return serial;
        }
    }
}
