public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> list = new List<List<string>>();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        
        string str;
        string sortedStr;

        for(int i = 0; i < strs.Length; i++){
            str = strs[i];
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            sortedStr = new String(chars);

            if(dict.ContainsKey(sortedStr)){
                dict[sortedStr].Add(str);
            } else {
                //make new
                dict.Add(sortedStr, new List<string> { str });
            }

        }

        return dict.Values.ToList();
    }
}
