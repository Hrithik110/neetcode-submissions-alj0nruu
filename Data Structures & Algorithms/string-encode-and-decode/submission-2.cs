public class Solution {

    public string Encode(IList<string> strs) {
        Console.WriteLine(strs.Count);
        if(strs.Count == 0 ) return "empty";
        return String.Join(";", strs);
    }

    public List<string> Decode(string s) {
        if(s == "empty") return new List<string>();
        return s.Split(";").ToList<string>();
    }
}
