public class TimeMap {

    private Dictionary<string, List<TimeMapValue>> _map;
    public TimeMap() {
        _map = new Dictionary<string, List<TimeMapValue>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!_map.ContainsKey(key)) {
            _map[key] = new List<TimeMapValue>();
        }
        _map[key].Add(new TimeMapValue(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
         if (!_map.ContainsKey(key)) return "";

        var values = _map[key];
        int l = 0, r = values.Count - 1;
        string res = "";

        // Binary search for the largest timestamp <= given timestamp
        while (l <= r) {
            int mid = l + (r - l) / 2;
            if (values[mid].Timestamp <= timestamp) {
                res = values[mid].Value;
                l = mid + 1;
            } else {
                r = mid - 1;
            }
        }
        return res;
    }
}

public class TimeMapValue{
    public string Value;
    public int Timestamp;

    public TimeMapValue(string value, int timestamp){
        Value = value;
        Timestamp = timestamp;
    }
}