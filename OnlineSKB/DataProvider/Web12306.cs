using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;

namespace OnlineSKB
{
    class Web12306 : IQuery
    {
        private const string URL_BY_STATION_STATION = "http://dynamic.12306.cn/TrainQuery/iframeTrainInfoByStation.jsp";
        private const string URL_BY_TRAIN_CODE = "http://dynamic.12306.cn/TrainQuery/trainPassStationByTrainCode.jsp";
        private const string URL_BY_STATION = "http://dynamic.12306.cn/TrainQuery/iframePassTrainInfoByStation.jsp";
        private const string URL_TRAIN_INFO = "http://dynamic.12306.cn/TrainQuery/iframeTrainPassStationByTrainCode.jsp";
        private const string URL_AUTO_COMPLETE = "http://dynamic.12306.cn/TrainQuery/autocomplete.do";

        #region IQuery Members

        public string[] StationNameFromAbbr(string code, DateTime date)
        {
            return GetAutoComplete(code, 1, date);
        }

        public TrainInfo[] ByStationSataion(string departure, string destination, DateTime date)
        {
            string[,] postData = new string[,] {
                { "arriveStation", destination.Trim() },
                { "arriveStation_new_value", "true" },
                { "name_ckball", "value_ckball" },
                { "nday1", date.Day.ToString().PadLeft(2, '0') },
                { "nday1_new_value", "true" },
                { "nmonth1", date.Month.ToString().PadLeft(2, '0') },
                { "nmonth1_new_value", "true" },
                { "rFlag", "1" },
                { "startStation", departure.ToString() },
                { "startStation_new_value", "true" },
                { "tFlagDC", "DC" },
                { "tFlagK", "K" },
                { "tFlagLK", "LK" },
                { "tFlagPK", "PK" },
                { "tFlagPKE", "PKE" },
                { "tFlagT", "T" },
                { "tFlagZ", "Z" }
            };

            HttpWebResponse response = GetResponseFromWeb(URL_BY_STATION_STATION, postData);
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            StreamReader sr = new StreamReader(response.GetResponseStream());

            while (!sr.EndOfStream)
            {
                //parent.mygrid.addRow(1,"2,
                // K8355^skbcx.jsp?cxlx=cc&date=20100704&trainCode=K8355,
                // 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100704&stationName_passTrain=%E5%8D%97%E4%BA%AC^self,  
                // 苏州^skbcx.jsp?cxlx=czjgcc&zm=&date=20100704&stationName_passTrain=%E8%8B%8F%E5%B7%9E^self,
                // 00:49,
                // 03:30,
                // 02:41,
                // 连云港东^skbcx.jsp?cxlx=czjgcc&zm=&date=20100704&stationName_passTrain=%E8%BF%9E%E4%BA%91%E6%B8%AF%E4%B8%9C^self,
                // 杭州^skbcx.jsp?cxlx=czjgcc&zm=&date=20100704&stationName_passTrain=%E6%9D%AD%E5%B7%9E^self, 
                // 快速 ,
                // 33,50,79/84/87,119/125,--,--,--",1);

                TrainInfo ti = new TrainInfo();
                string line = sr.ReadLine();
                if ((line.IndexOf("//") == -1) && (line.IndexOf("addRow") != -1))
                {
                    string[] items = line.Split(',');
                    ti.Index = int.Parse(items[1].Split('"')[1].ToString());
                    ti.Code = items[2].Split('^')[0].Trim();
                    ti.RangeDeparture = items[3].Split('^')[0].Trim();
                    ti.RangeDestination = items[4].Split('&')[0].Trim();
                    ti.RangeDepartTime = GetTime(items[5]);
                    ti.RangeDestTime = GetTime(items[6]);
                    ti.RangeDuration = items[7].Trim();
                    ti.TrainDeparture = items[8].Split('^')[0].Trim();
                    ti.TrainDestination = items[9].Split('^')[0].Trim();
                    ti.TrainClass = items[10].Trim();
                    array.Add(ti);
                }
            }
            sr.Close();
            response.Close();
            return array.ToArray(typeof(TrainInfo)) as TrainInfo[];

        }
        //public TrainInfo[] StationSataion(string departure, string destination, DateTime date)
        //{
        //    // curl http://dynamic.12306.cn/TrainQuery/iframeLeftTicketByStation.jsp  -d lx=00 -d nyear3=$YEAR -d nyear3_new_value=true -d nmonth3=$MON -d nmonthe3_new_value=true -d nday3=$DAY —data-urlencode startStation_ticketLeft=$START —data-urlencode arriveStation_ticketLeft=$TO -d nday3_new_value=true -d startStation_ticketLeft_new_value=true -d arriveStation_ticketLeft_new_value=true -d trainCode=$TRAINCODE -d trainCode_new_value=true -d rFlag=1 -d name_ckball=value_ckball -d tFlagT=T -d tFlagZ=Z -d tFlagDC=DC -d tFlagK=K -d tFlagPK=PK -d tFlagQT=QT -m 10 2>/dev/null ｜ grep -v "//" ｜ grep addRow > $TMPFILE
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dynamic.12306.cn/TrainQuery/iframeLeftTicketByStation.jsp");
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("lx=00&");
        //    sb.Append("nyear3=" + date.Year.ToString() + "&");
        //    sb.Append("nyear3_new_value=true&");
        //    sb.Append("nmonth3=" + date.Month.ToString().PadLeft(2, '0') + "&");
        //    sb.Append("nmonthe3_new_value=true&");
        //    sb.Append("nday3=" + date.Day.ToString().PadLeft(2, '0') + "&");
        //    sb.Append("startStation_ticketLeft=" + departure + "&");
        //    sb.Append("arriveStation_ticketLeft=" + destination + "&");
        //    sb.Append("nday3_new_value=true&");
        //    sb.Append("startStation_ticketLeft_new_value=true&");
        //    sb.Append("arriveStation_ticketLeft_new_value=true&");
        //    sb.Append("trainCode=&");
        //    sb.Append("trainCode_new_value=true&");
        //    sb.Append("rFlag=1&name_ckball=value_ckball&tFlagT=T&tFlagZ=Z&tFlagDC=DC&tFlagK=K&tFlagPK=PK&tFlagQT=QT");
        //    byte[] data = (new UTF8Encoding()).GetBytes(sb.ToString());
        //    request.Method = "POST";
        //    request.ContentType = "application/x-www-form-urlencoded";
        //    request.ContentLength = data.Length;
        //    Stream newStream = request.GetRequestStream();
        //    //  Send the data.
        //    newStream.Write(data, 0, data.Length);
        //    newStream.Close();

        //    HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        //    StreamReader resStream = new StreamReader(response.GetResponseStream());
        //    System.Collections.ArrayList array = new System.Collections.ArrayList();
        //    while (!resStream.EndOfStream)
        //    {
        //        TrainInfo ti = new TrainInfo();
        //        string line = resStream.ReadLine();
        //        if ((line.IndexOf("//") == -1) && (line.IndexOf("addRow") != -1))
        //        {
        //            //parent.mygrid.addRow(76,"77,T115(兰州->上海)^skbcx.jsp?cxlx=cc&date=20100701&trainCode=T115 ,南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100701&stationName_passTrain=%E5%8D%97%E4%BA%AC , 上海^skbcx.jsp?cxlx=czjgcc&zm=&date=20100701&stationName_passTrain=%E4%B8%8A%E6%B5%B7, 09:46 ,12:41 ,02:55, 0 , -- ,240,0,--,--,--,无,特快" , 76);
        //            ti.Code = line.Split(',')[2].Split('(')[0];
                    
        //            ti.RangeDeparture = line.Split(',')[2].Split('(')[1].Split('-')[0];
        //            ti.RangeDestination = line.Split(',')[2].Split('(')[1].Split('>')[1].Split(')')[0];
        //            ti.RangeDepartTime = DateTime.Parse(line.Split(',')[5].Trim());
        //            ti.RangeDestTime = DateTime.Parse(line.Split(',')[6].Trim());
        //            array.Add(ti);
        //        }
        //    }
        //    resStream.Close();
        //    response.Close();
        //    return array.ToArray(typeof(TrainInfo)) as TrainInfo[];
        //}

        public TrainInfo[] ByStation(string station, DateTime date)
        {
            string[,] postData = new string[,] {
                { "name_ckball", "value_ckball" },
                { "nday1", date.Day.ToString().PadLeft(2, '0'), },
                { "nday1_new_value", "true" },
                { "nmonth1", date.Month.ToString().PadLeft(2, '0') },
                { "nmonth1_new_value", "true" },
                { "radio", "1" },
                { "stationName_passTrain", station.Trim() },
                { "stationName_passTrain_new_value", "true" },
                { "tFlagDC", "DC" },
                { "tFlagK", "K" },
                { "tFlagLK", "LK" },
                { "tFlagPK", "PK" },
                { "tFlagPKE", "PKE" },
                { "tFlagT", "T" },
                { "tFlagZ", "Z" }
            };

            HttpWebResponse response = GetResponseFromWeb(URL_BY_STATION, postData);
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                // parent.mygrid.parse("<?xml version='1.0' ?><rows><row id ='0'>
                // <cell>1</cell>
                // <cell><![CDATA[ G7106^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7106]]></cell>
                // <cell>高速</cell>
                // <cell><![CDATA[ 上海虹桥^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7%E8%99%B9%E6%A1%A5]]></cell>
                // <cell>06:12</cell>
                // <cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell>
                // <cell>08:09</cell>
                // <cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell>
                // <cell>07:10</cell>
                // <cell>07:09</cell>
                // <cell>00:57</cell></row><row id ='1'><cell>2</cell><cell><![CDATA[ G7107^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7107]]></cell><cell>高速</cell><cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell><cell>06:52</cell><cell><![CDATA[ 上海虹桥^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7%E8%99%B9%E6%A1%A5]]></cell><cell>08:45</cell><cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell><cell>07:49</cell><cell>07:46</cell><cell>00:54</cell></row><row id ='2'><cell>3</cell><cell><![CDATA[ G7013^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7013]]></cell><cell>高速</cell><cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell><cell>11:25</cell><cell><![CDATA[ 上海^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7]]></cell><cell>13:05</cell><cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell><cell>12:17</cell><cell>12:14</cell><cell>00:49</cell></row><row id ='3'><cell>4</cell><cell><![CDATA[ G7142^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7142]]></cell><cell>高速</cell><cell><![CDATA[ 上海虹桥^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7%E8%99%B9%E6%A1%A5]]></cell><cell>11:41</cell><cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell><cell>13:39</cell><cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell><cell>12:39</cell><cell>12:37</cell><cell>00:56</cell></row><row id ='4'><cell>5</cell><cell><![CDATA[ G7023^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7023]]></cell><cell>高速</cell><cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell><cell>14:45</cell><cell><![CDATA[ 上海^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7]]></cell><cell>16:55</cell><cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell><cell>15:56</cell><cell>15:53</cell><cell>01:08</cell></row><row id ='5'><cell>6</cell><cell><![CDATA[ G7164^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7164]]></cell><cell>高速</cell><cell><![CDATA[ 上海虹桥^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7%E8%99%B9%E6%A1%A5]]></cell><cell>15:50</cell><cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell><cell>17:38</cell><cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell><cell>16:47</cell><cell>16:46</cell><cell>00:56</cell></row><row id ='6'><cell>7</cell><cell><![CDATA[ G7035^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7035]]></cell><cell>高速</cell><cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell><cell>18:42</cell><cell><![CDATA[ 上海^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7]]></cell><cell>20:37</cell><cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell><cell>19:34</cell><cell>19:31</cell><cell>00:49</cell></row><row id ='7'><cell>8</cell><cell><![CDATA[ G7038^skbcx.jsp?cxlx=cc&date=20100702&trainCode=G7038]]></cell><cell>高速</cell><cell><![CDATA[ 上海^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E4%B8%8A%E6%B5%B7]]></cell><cell>19:23</cell><cell><![CDATA[ 南京^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC]]></cell><cell>21:18</cell><cell><![CDATA[ 戚墅堰^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E6%88%9A%E5%A2%85%E5%A0%B0]]></cell><cell>20:26</cell><cell>20:25</cell><cell>01:02</cell></row>#8#</rows>", "xml");
                
                if ((line.IndexOf("//") == -1) && (line.IndexOf("parent.mygrid.parse") != -1))
                {
                    
                    int start = line.IndexOf("<?xml");
                    string xml = "";
                    line = line.Substring(start);
                    int end = -1;
                    while ((end = line.LastIndexOf("</rows>")) == -1)
                    {
                        xml += line;
                        line = sr.ReadLine();
                        if (sr.EndOfStream)
                            throw new Exception("Error in return data");
                    }
                    xml = xml + line.Substring(0, end + 7);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(xml);
                    XmlNodeList xnl = xmlDoc.GetElementsByTagName("row");
                    foreach (XmlNode xn in xnl)
                    {
                        TrainInfo ti = new TrainInfo();
                        ti.Index = int.Parse(xn.ChildNodes[0].InnerText);
                        ti.Code = xn.ChildNodes[1].InnerText.Split('^')[0];
                        ti.TrainClass = xn.ChildNodes[2].InnerText.Trim();
                        ti.TrainDeparture = xn.ChildNodes[3].InnerText.Split('^')[0].Trim();
                        ti.TrainDepartTime = GetTime(xn.ChildNodes[4].InnerText);
                        ti.TrainDestination = xn.ChildNodes[5].InnerText.Split('^')[0].Trim();
                        ti.TrainDestTime = GetTime(xn.ChildNodes[6].InnerText);
                        ti.RangeDeparture = xn.ChildNodes[7].InnerText.Trim();
                        ti.RangeDepartTime = GetTime(xn.ChildNodes[8].InnerText);
                        ti.RangeDestTime = GetTime(xn.ChildNodes[9].InnerText);
                        ti.RangeDuration = xn.ChildNodes[10].InnerText.Trim();
                        array.Add(ti);
                    }
                    break;                    
                }
            }

            sr.Close();
            response.Close();
            return array.ToArray(typeof(TrainInfo)) as TrainInfo[];         
            
        }

        public TrainInfo[] ByTrainCode(string code, DateTime date)
        {
            string[] codes = GetAutoComplete(code, 0, date);
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            foreach (string c in codes)
            {
                if (c.IndexOf(code) != -1)
                {
                    TrainInfo ti = GetTrainInfo(c, date);
                    ti.TrainDuration = ti.StationInfo[ti.StationInfo.Length - 1].Duration;
                    array.Add(ti);
                }

            }
            return array.ToArray(typeof(TrainInfo)) as TrainInfo[];
            //string [,] postData = new string [,] {
            //    { "nday1", date.Day.ToString().PadLeft(2, '0'), },
            //    { "nday1_new_value",	"true", },
            //    { "nmonth1", date.Month.ToString().PadLeft(2, '0'), },
            //    { "nmonth1_new_value", "true", },
            //    { "trainCode", code.Trim(), },
            //    { "trainCode_new_value", "true", },
            //};

            //HttpWebResponse response = GetResponseFromWeb(URL_BY_TRAIN_CODE, postData);
            //System.Collections.ArrayList array = new System.Collections.ArrayList();
            //StreamReader sr = new StreamReader(response.GetResponseStream());
            //while (!sr.EndOfStream)
            //{
            //    TrainInfo ti = new TrainInfo(); 
            //    string line = sr.ReadLine();
            //    // parent.mygrid.addRow(0,"1,南京西^skbcx.jsp?cxlx=czjgcc&zm=&date=20100702&stationName_passTrain=%E5%8D%97%E4%BA%AC%E8%A5%BF ,2001    , ---- , 12:10 , --,--, --, --,   --, --,  -- ,--",0);
            //    if ((line.IndexOf("//") == -1) && (line.IndexOf("parent.mygrid.addRow") != -1))
            //    {
            //        string [] splitedLine = line.Split(',');
            //        ti.Index = int.Parse(splitedLine[0].Split('\"')[1].Trim());
                    
            //    }
            //    array.Add(ti);
            //}

            //sr.Close();
            //response.Close();
            //return array.ToArray(typeof(TrainInfo)) as TrainInfo[];         
           
        }

        public TrainInfo GetTrainInfo(string code, DateTime date)
        {
            string[,] postData = new string[,] 
            {
                { "nmonth1" , date.Month.ToString().PadLeft(2, '0') },
                { "nmonthe1_new_value", "true" },
                { "nday1", date.Day.ToString().PadLeft(2, '0') },
                { "nday1_new_value", "true" },
                { "trainCode", code.Trim() },
                { "trainCode_new_value", "true" }
            };
            HttpWebResponse response = GetResponseFromWeb(URL_TRAIN_INFO, postData);
            StreamReader resStream = new StreamReader(response.GetResponseStream());
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            TrainInfo ti = new TrainInfo();
            
            while (!resStream.EndOfStream)
            {
                string line = resStream.ReadLine();
                if (line.IndexOf("parent.document.getElementById(\"trainCodeDIV\").innerHTML=") != -1)
                {
                    ti.Code = line.Split('>')[1].Split('<')[0];
                    continue;
                }
                if ((line.IndexOf("//") == -1) && (line.IndexOf("parent.mygrid.addRow") != -1))
                {
                    //parent.mygrid.addRow(2,"3,苏州^skbcx.jsp?cxlx=czjgcc&zm=&date=20100627&stationName_passTrain=%E8%8B%8F%E5%B7%9E ,D5402   , 06:47 , 06:49 , 00:41,--, --, --,   --, 31,  26 ,--",2);
                    StationInfo si = new StationInfo();
                    string [] items = line.Split(',');
                    si.Name = items[2].Split('^')[0].Trim();
                    si.Code = items[3].Trim();
                    si.ArrivalTime = GetTime(items[4]);
                    si.DepartureTime = GetTime(items[5]);
                    si.Duration = items[6].Trim();
                    array.Add(si);
                }
            }
            ti.StationInfo = (StationInfo []) array.ToArray(typeof(StationInfo));
            ti.TrainDeparture = ti.StationInfo[0].Name;
            ti.TrainDepartTime = ti.StationInfo[0].DepartureTime;
            ti.TrainDestination = ti.StationInfo[ti.StationInfo.Length - 1].Name;
            ti.TrainDestTime = ti.StationInfo[ti.StationInfo.Length - 1].ArrivalTime;
            resStream.Close();
            response.Close();
            return ti;
        }


        #endregion


        #region Helper Functions
        private HttpWebResponse GetResponseFromWeb(string url, string [,] postData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Proxy = System.Net.GlobalProxySelection.GetEmptyWebProxy();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < postData.GetLength(0); ++i)
            {
                sb.Append(postData[i, 0] + "=" + postData[i, 1] + "&");
            }
            if (sb[sb.Length - 1] == '&')
                sb.Remove(sb.Length - 1, 1);

            byte[] data = (new UTF8Encoding()).GetBytes(sb.ToString());
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            return (HttpWebResponse)request.GetResponse();
        }

        private DateTime GetTime(string time)
        {
            time = time.Trim();
            if (time != "----")
                return  DateTime.Parse(time);
            else
                return new DateTime(0);
        }

        private string [] GetAutoComplete(string keyword, int type, DateTime date)
        {
            string[] types = { "getTrainName", "getStationName" }; 
            if (type >= types.Length)
            {
                return null;
            }
            string[,] postData = new string[,] 
            {
                { "date", date.Date.ToString("yyyyMMdd") },
                { "inputValue", (keyword + "   ").Substring(0, 3).Trim().ToUpper() },
                { "method", types[type] }
            };

            HttpWebResponse response = GetResponseFromWeb(URL_AUTO_COMPLETE, postData);
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            StreamReader sr = new StreamReader(response.GetResponseStream());

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(sr);

            XmlNodeList xnl = xmlDoc.GetElementsByTagName("option");
            foreach (XmlNode xn in xnl)
            {
                array.Add(xn.Attributes["value"].Value);
            }
            sr.Close();
            response.Close();
            return (string []) array.ToArray(typeof(string));
        }

        #endregion
    }
}
