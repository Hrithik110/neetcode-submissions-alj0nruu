public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = 0;

        // find max pile
        foreach(int p in piles){
            r = Math.Max(r, p);
        }
        int minRate = int.MaxValue;
        while(l<=r){
            int mid = l + (r - l) / 2;

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
        int hoursReq = 0;

        for(int i = 0; i<piles.Length; i++){
            int req = (int) Math.Ceiling((double)piles[i]/rate);

            hoursReq += req;
        }

        return hoursReq<=h;
    }
}
