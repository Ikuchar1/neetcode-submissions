public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        long product = 1;
        int zeroCount = 0;
        foreach(int num in nums){
            if (num == 0){
                zeroCount++;
                continue;
            }
            product *= num;
        }

        Console.WriteLine(product);

        int[] prodList = new int[nums.Length];

        if(zeroCount >= 2){
            return prodList;
        }

        for(int i = 0; i < nums.Length; i++){
            int divisor = nums[i];

            if(zeroCount > 0){
                if (divisor == 0){
                    prodList[i] = (int) product;
                } else {
                    prodList[i] = 0;
                }
            } else {

                long value = product / nums[i];
                prodList[i] = (int)value;
            }

            
        }

        return prodList;
    }
}
