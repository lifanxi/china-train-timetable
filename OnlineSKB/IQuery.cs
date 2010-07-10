using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSKB
{
    public struct TrainInfo
    {
        public int Index { get; set; }
        public string Code { get; set; }
        public string RangeDeparture { get; set; }
        public string RangeDestination { get; set; }
        public DateTime RangeDepartTime { get; set; }
        public DateTime RangeDestTime { get; set; }
        public string RangeDuration { set; get; }
        public string TrainDeparture { get; set; }
        public string TrainDestination { get; set; }
        public DateTime TrainDepartTime { get; set; }
        public DateTime TrainDestTime { get; set; }
        public string TrainDuration { set; get; }
        public string TrainClass { get; set; }
        //public string RangeDuration
        //{
        //    get
        //    {
        //        DateTime zero = new DateTime(0);
        //        if ((RangeDepartTime != zero) && (RangeDestTime != zero))
        //        {
        //            TimeSpan ts = RangeDestTime - RangeDepartTime;
        //            return string.Format("{0:D2}:{1:D2}", ts.Hours, ts.Minutes);
        //        }
        //        else
        //            return "--";                
        //    }
        // }
        public StationInfo[] StationInfo;
    }
    
    public struct StationInfo
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string ArrivalTimeDisplay
        {
            get
            {
                if (ArrivalTime != new DateTime(0))
                {
                    return ArrivalTime.ToString("HH:mm");
                }
                else
                {
                    return "--";
                }
            }
        }
        public string DepartureTimeDisplay
        {
            get
            {
                if (DepartureTime != new DateTime(0))
                {
                    return DepartureTime.ToString("HH:mm");
                }
                else
                {
                    return "--";
                }
            }
        }
        public Price Price { get; set; }
        public int Distance { get; set; }
        public string Duration { get; set; }
    }

    public enum PriceType
    {
        YZ, RZ, RZT, YWS, YWZ, YWX, RWS, RWX, GRWS, GRWX, ZY, ZE 
    }

    public class Price : System.Collections.Generic.Dictionary <PriceType, Decimal>
    {
        
    }
    

    interface IQuery
    {
        TrainInfo[] ByStationSataion(string departure, string destination, DateTime date);
        TrainInfo[] ByStation(string station, DateTime date);
        TrainInfo[] ByTrainCode(string code, DateTime date);
        TrainInfo GetTrainInfo(string code, DateTime date);

        string[] StationNameFromAbbr(string code, DateTime date);
    }
}
