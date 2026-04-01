public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int l = 0;
        int r = numbers.Length - 1;

        while(l<r){
            int sum = numbers[l] + numbers[r];

            if(sum == target){
                int index1 = Array.IndexOf(numbers, numbers[l]);
                int index2 = Array.IndexOf(numbers, numbers[r], index1+1);

                return new int[] {index1+1, index2+1};
            }

            else if(sum<target){
                l++;
            }
            else{
                r--;
            }

        }

        return Array.Empty<int>();
    }
}
