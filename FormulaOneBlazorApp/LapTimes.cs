namespace Formula1BlazorApp.Data
{
    public class LapTimes
    {
        private string _sectorOne;
        private string _sectorTwo;
        private string _sectorThree;
        private string _lapTime;
        private int _lap;
        private bool _outLap;
        private string _driver;
        private List<PitInfo> _pitStops = new List<PitInfo>();

        public string SectorOne
        {
            get { return _sectorOne; }
            set { _sectorOne = value; }
        }

        public string SectorTwo
        {
            get { return _sectorTwo; }
            set { _sectorTwo = value; }
        }

        public string SectorThree
        {
            get { return _sectorThree; }
            set { _sectorThree = value; }
        }

        public string LapTime
        {
            get { return _lapTime; }
            set { _lapTime = value; }
        }

        public int Lap
        {
            get { return _lap; }
            set { _lap = value; }
        }

        public bool OutLap
        {
            get { return _outLap; }
            set { _outLap = value; }
        }

        public string Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        public List<PitInfo> PitStops
        {
            get { return _pitStops; }
            set { _pitStops = value; }
        }
    }


}