using System;
using System.Collections.Generic;

namespace Common
{
    public class SectConfig
    {
        public string DllName { get; set; }
        public string ClassName { get; set; }
        public string SectName { get; set; }
        public ConsoleColor OutColor { get; set; }
        public int PayMoney { get; set; }
        public int CurTemperature { get; set; }
        public int TriggerTemperature { get; set; }
        public string Person { get; set; }
        public string Desk { get; set; }
        public string Chair { get; set; }
        public string Fan { get; set; }
        public string Ruler { get; set; }
        public List<string> EventList { get; set; }

    }
}