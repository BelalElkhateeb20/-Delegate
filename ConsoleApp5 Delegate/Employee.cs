﻿namespace ConsoleApp5_Delegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalSales { get; set; }
        public string Gender { get; set; }
        private string location { get; set; }

        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

    }
}
