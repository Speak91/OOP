using System;

namespace File_Manager
{
    /// <summary>
    /// Класс для общей информации об обьектах информации
    /// </summary>
    public abstract class Info
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public long Size { get; set; }
        public DateTime CreateTime { get; set; }
        public string Extension { get; set; }
    }

}
