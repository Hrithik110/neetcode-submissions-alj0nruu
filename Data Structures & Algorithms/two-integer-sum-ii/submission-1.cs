public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i<numbers.Length; i++){
            int compliment = target - numbers[i];

            if(map.ContainsKey(compliment)){
                return new int[]{map[compliment]+1, i+1};
            }

            map[numbers[i]] = i;
        }
        return Array.Empty<int>();
    }
}
