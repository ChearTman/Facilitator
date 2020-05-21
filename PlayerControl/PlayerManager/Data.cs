using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Data
{
    #region Lists
    static List<stringModel> stringData = new List<stringModel>();
    static List<longModel> longData = new List<longModel>();
    static List<booleanModel> booleanData = new List<booleanModel>();
    #endregion

    #region setData
    public void SetData(ulong Steam64ID, string DataName, string Text)
    {
        if (stringData.Any(data => data.Steam64ID == Steam64ID))
            if (stringData.Any(data => data.Steam64ID == Steam64ID && data.DataName == DataName))
                stringData[stringData.IndexOf(stringData.Where(where => where.Steam64ID == Steam64ID && where.DataName == DataName).First())] = new stringModel(Steam64ID, DataName, Text);
            else
                stringData.Add(new stringModel(Steam64ID, DataName, Text));
        else
            stringData.Add(new stringModel(Steam64ID, DataName, Text));
    }

    public void SetData(ulong Steam64ID, string DataName, long Number)
    {
        if (longData.Any(data => data.Steam64ID == Steam64ID))
            if (longData.Any(data => data.Steam64ID == Steam64ID && data.DataName == DataName))
                longData[longData.IndexOf(longData.Where(where => where.Steam64ID == Steam64ID && where.DataName == DataName).First())] = new longModel(Steam64ID, DataName, Number);
            else
                longData.Add(new longModel(Steam64ID, DataName, Number));
        else
            longData.Add(new longModel(Steam64ID, DataName, Number));
    }

    public  void SetData(ulong Steam64ID, string DataName, bool Bool)
    {
        if (booleanData.Any(data => data.Steam64ID == Steam64ID))
            if (booleanData.Any(data => data.Steam64ID == Steam64ID && data.DataName == DataName))
                booleanData[booleanData.IndexOf(booleanData.Where(where => where.Steam64ID == Steam64ID && where.DataName == DataName).First())] = new booleanModel(Steam64ID, DataName, Bool);
            else
                booleanData.Add(new booleanModel(Steam64ID, DataName, Bool));
        else
            booleanData.Add(new booleanModel(Steam64ID, DataName, Bool));

    }
    #endregion

    #region getData
    public string getDataText(ulong Steam64ID, string DataName) => stringData[stringData.FindIndex(data => data.Steam64ID == Steam64ID && data.DataName == DataName)].Text;
    public long getDataNumber(ulong Steam64ID, string DataName) => longData[longData.FindIndex(data => data.Steam64ID == Steam64ID && data.DataName == DataName)].Long;
    public bool getDataBool(ulong Steam64ID, string DataName) => booleanData[booleanData.FindIndex(data => data.Steam64ID == Steam64ID && data.DataName == DataName)].Boolean;
    #endregion

    #region Models
    public class stringModel
    {
        public ulong Steam64ID { get; set; }
        public string DataName { get; set; }
        public string Text { get; set; }

        public stringModel(ulong steam64id, string dataname, string text)
        {
            Steam64ID = steam64id;
            DataName = dataname;
            Text = text;
        }
    }

    public class longModel
    {
        public ulong Steam64ID { get; set; }
        public string DataName { get; set; }
        public long Long { get; set; }

        public longModel(ulong steam64id, string dataname, long getLong)
        {
            Steam64ID = steam64id;
            DataName = dataname;
            Long = getLong;
        }
    }

    public class booleanModel
    {
        public ulong Steam64ID { get; set; }
        public string DataName { get; set; }
        public bool Boolean { get; set; }

        public booleanModel(ulong steam64id, string dataname, bool boolean)
        {
            Steam64ID = steam64id;
            DataName = dataname;
            Boolean = boolean;
        }
    }

    #endregion  
}



