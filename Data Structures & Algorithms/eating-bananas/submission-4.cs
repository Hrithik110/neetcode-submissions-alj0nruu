public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        Array.Sort(piles);

        int l = 1, r = piles[piles.Length - 1];
        int min = piles[piles.Length - 1];
        while(l<=r){
            int mid = l + (r-l)/2;

            if(CanEatInGivenHours(piles, h, mid)){
                r = mid - 1;
                min = Math.Min(min, mid);
            }
            else{
                l = mid + 1;
            }
        }

        return min;
    }

    public bool CanEatInGivenHours(int[] piles, int h, int rate){
        int hours = 0;
        for(int i = 0; i<piles.Length; i++){
            hours += (piles[i] + rate - 1)/rate;
        }

        return hours <= h;
    }
}
