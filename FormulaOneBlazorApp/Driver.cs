using System;

namespace Formula1BlazorApp
{
    public class Driver
    {
        private string _firstName;
        private string _sureName;
        private string _team;
        private int _driverNumber;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string SureName
        {
            get { return _sureName; }
            set { _sureName = value; }
        }

        public string Team
        {
            get { return _team; }
            set { _team = value; }
        }

        public int DriverNumber
        {
            get { return _driverNumber; }
            set { _driverNumber = value; }
        }
    }
}