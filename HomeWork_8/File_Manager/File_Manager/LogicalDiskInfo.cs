using System;
using System.Collections.Generic;
using System.IO;

namespace File_Manager
{
    /// <summary>
    /// Информация о дисках компьютера
    /// </summary>
    public class LogicalDiskInfo : Info
    {
        private DriveInfo[] _allDrives = DriveInfo.GetDrives();
        private List<LogicalDiskInfo> _discInfo = new List<LogicalDiskInfo>();
        public string DiskType { get; set; }
       
        /// <summary>
        /// Возвращает информацию о дисках
        /// </summary>

        public List<LogicalDiskInfo> DiscInfo ()
        {
            
            foreach (var disk in _allDrives)
            {
                if (disk.IsReady)
                {
                    _discInfo.Add(new LogicalDiskInfo { Name = disk.Name, DiskType = disk.DriveType.ToString(), Size = disk.TotalSize/ 1073741824 });
                }
                else
                {
                    _discInfo.Add(new LogicalDiskInfo { Name = disk.Name, DiskType = disk.DriveType.ToString() });
                }
               
            }
            return _discInfo;
        }
      
    }

}
