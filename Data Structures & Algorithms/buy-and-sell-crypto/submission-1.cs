public class Solution {
    public int MaxProfit(int[] prices) {
        var buyingPrice = prices[0];
        int maxProfit = 0;
        for(int i = 1; i<prices.Length; i++){
            if(prices[i]<buyingPrice){
                buyingPrice = prices[i];
            }
            else{
                maxProfit = Math.Max(maxProfit, prices[i]-buyingPrice);
            }
        }
        return maxProfit;
    }
}
