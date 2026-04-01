public class TimeMap {
    private Dictionary<string, List<TimeMapValues>> _map;
    public TimeMap() {
        _map = new Dictionary<string, List<TimeMapValues>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!_map.ContainsKey(key)){
            _map[key] = new List<TimeMapValues>();
        }
        _map[key].Add(new TimeMapValues(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if(!_map.ContainsKey(key)) return "";

        var values = _map[key];

        int l = 0, r = values.Count - 1;
        string res = "";

        while(l<=r){
            int mid = l + (r-l)/2;

            if(values[mid].TimeStamp <=timestamp){
                res = values[mid].Val;
                l=mid+1;
            }
            else{
                r = mid - 1;
            }
        }
        return res;
    }
}

public class TimeMapValues{
    public string Val;
    public int TimeStamp;

    public TimeMapValues(string value, int timestamp){
        Val = value;
        TimeStamp = timestamp;
    }
}