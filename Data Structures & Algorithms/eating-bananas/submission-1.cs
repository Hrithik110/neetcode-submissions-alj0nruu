public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        Array.Sort(piles);

        int l = 0, r = piles[piles.Length - 1];
        int minRate = int.MaxValue;
        while(l<=r){
            double mid1 = l + (r-l)/2;
            int mid = (int)Math.Floor(mid1);

            if(checkCanEat(piles, mid,h )){
                r = mid-1;
                minRate = Math.Min(minRate, mid);
            }
            else{
                l = mid  + 1;
            }
        }

        return minRate;

    }

    public bool checkCanEat(int [] piles, int rate, int h){
       if(rate == 0) return false;
        int hoursReq = 0;

        for(int i = 0; i<piles.Length; i++){
            int req = (int) Math.Ceiling((double)piles[i]/rate);

            hoursReq += req;
        }

        return hoursReq<=h;
    }
}
