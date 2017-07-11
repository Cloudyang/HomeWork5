using System;
using System.Collections.Generic;

namespace Common
{
    public class FoodConfig
    {
        public string DllName { get; set; }
        public string ClassName { get; set; }
        public ConsoleColor OutColor { get; set; }
        public string FoodName { get; set; }
        public decimal Amount { get; set; }
        public string Specification { get; set; }
        public List<string> EventList { get; set; }

        //public FoodConfig()
        //{
        //    EventList = new List<string>();
        //}
    }
}