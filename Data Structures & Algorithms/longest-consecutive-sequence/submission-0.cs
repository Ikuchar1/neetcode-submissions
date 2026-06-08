public class Solution {
    public int LongestConsecutive(int[] nums) {
        //add them all to a hashset
        HashSet<int> numbers = new HashSet<int>();

        int maxCons = 0;

        foreach(int num in nums){
            if (!numbers.Contains(num)){
                numbers.Add(num);
            }

            int currNum = num;
            int currCount = 1;

            //go backwards
            while(numbers.Contains(currNum - 1)){
                currCount++;
                currNum--;
            }

            currNum = num;

            while(numbers.Contains(currNum + 1)){
                currCount++;
                currNum++;
            }

            maxCons = Math.Max(maxCons, currCount);
        }

        return maxCons;
    }
}
