public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int leftPrice;
        int rightPrice;

        int maxProfit = 0;
        int profit = 0;

        while(right < prices.Length){
            leftPrice = prices[left];
            rightPrice = prices[right];

            profit = rightPrice - leftPrice;

            if (rightPrice <= leftPrice){
                left = right;
            } else {
                maxProfit = Math.Max(maxProfit, profit);     
            }

            right++;
        }

        return maxProfit;

    }
}
