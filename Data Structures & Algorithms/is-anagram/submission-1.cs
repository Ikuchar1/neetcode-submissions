public class Solution {
    public bool IsAnagram(string s, string t) {

        //check if both same length
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();

        char sChar;
        char tChar;

        for(int i = 0; i < s.Length; i++){

            //get chars
            sChar = s[i];
            tChar = t[i];

            //check if dicts contain key
            if(dict1.ContainsKey(sChar)){
                
                dict1[sChar] += 1;

            } else {
                dict1.Add(sChar, 1);
            }

            if(dict2.ContainsKey(tChar)){
                
                dict2[tChar] += 1;
                
            } else {
                dict2.Add(tChar, 1);
            }
        }

        //return dict1.Count == dict2.Count && !dict1.Except(dict2).Any();

        foreach(var kvp in dict1){
            char c = kvp.Key;
            int count = kvp.Value;

            if (!dict2.ContainsKey(c) || dict2[c] != count){
                return false;
            }

            
        }

        return true;
    }
}
