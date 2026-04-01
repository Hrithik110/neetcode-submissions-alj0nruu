public class Solution {

    public string Encode(IList<string> strs) {
        
        // strs --> ["Hello","World"]
        //5#Hello5#World
        StringBuilder encoded = new StringBuilder();
        foreach(string str in strs){
            encoded.Append(str.Length).Append("#").Append(str);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        int i = 0;

        while(i<s.Length){
            int j = i;

            while(s[j] != '#'){
                j++;
            }

            int length = int.Parse(s.Substring(i, j-i));

            string str = s.Substring(j+1, length);

            result.Add(str);
            i = j+1+length;
        }

        return result;
    }
}
