public class Solution {
    public int MaxProfit(int[] prices) {
        
        int buyingPrice = prices[0];

        int maxProfit = 0;

        for(int i = 1; i<prices.Length; i++){
            if(prices[i]<buyingPrice){
                buyingPrice = prices[i];
            }
            else{
                int profit = prices[i] - buyingPrice;

                maxProfit = Math.Max(profit, maxProfit);
            }

        }
        return maxProfit;
    }
}
