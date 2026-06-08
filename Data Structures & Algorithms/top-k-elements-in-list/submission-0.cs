public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {


        List<int>[] buckets = new List<int>[nums.Length + 1];
        Dictionary<int, int> dict = new Dictionary<int, int>();

        int num;

        //go thru each bucket and init it
        for (int i = 0; i < buckets.Length; i++){
            buckets[i] = new List<int>();
        }

        //fill in buckets
        for(int i = 0; i < nums.Length; i++){

            num = nums[i];

            //check if dict contains the num
            if(!dict.ContainsKey(num)){
                dict.Add(num, 1);
                buckets[1].Add(num);
            } else {
                //find index
                int index = dict[num];
                buckets[index].Remove(num);

                //add to next bucket
                //add one to dict num value (2nd int)
                dict[num]++;
                buckets[index + 1].Add(num);
            }

        }

        //get topK
        List<int> topKList = new List<int>();

        for(int i = buckets.Length - 1; i >= 0; i--){
            //go thru add it to topKList
            if(topKList.Count >= k){
                break;
            } else {
                topKList.AddRange(buckets[i]);
            }
        }
        

        return topKList.ToArray();
    }
}
