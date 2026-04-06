public class Solution {
    public int LeastInterval(char[] tasks, int n) {
     //Eg. AAABBCCD n = 3
     //A -> B -> C -> D -> A -> B -> C-> idle -> A
     // maxFreq = 3
     // countOfMax = 1
     //partition = 3+1 = 4
     // 3-1 * 4 + 1

     var freq = new Dictionary<char, int>();

     foreach(char task in tasks){
        freq[task] = freq.GetValueOrDefault(task, 0) + 1;
     }

     int maxFreq = 0;

     foreach(var kv in freq){
        maxFreq = Math.Max(maxFreq, kv.Value);
     }

     int countMaxFreq = 0;

     foreach(var kv in freq){
        if(kv.Value == maxFreq){
            countMaxFreq++;
        }
     }

        int partCount = maxFreq-1;
        int partition = n + 1;

        int ans = partCount * partition + countMaxFreq;

        return Math.Max(tasks.Length, ans);
    }
}
