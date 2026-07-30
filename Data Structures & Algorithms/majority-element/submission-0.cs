public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        foreach (int num in nums){

            if(!map.ContainsKey(num)){

                map.Add(num, 0);

            }

            map[num]++;

            if (map[num] > (nums.Length / 2)){
                return num;
            }

        }

        return -1;
    }
}