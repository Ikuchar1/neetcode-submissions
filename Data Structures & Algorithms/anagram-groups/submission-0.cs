public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //add string to a list. 
        // go thru entire list to see if it is anagram with 1st word in the list
        //if so use AddRange to add new string list to compared list

        List<List<string>> list = new List<List<string>>();
        string str;

        for(int i = 0; i < strs.Length; i++){
            str = strs[i];
            bool isAnagram = false;

            foreach(List<string> l in list){
                isAnagram = IsAnagram(str, l[0]);
                if (isAnagram){
                    l.Add(str);
                    break;
                }
            }

            if(!isAnagram){
                list.Add(new List<string> { str });
            }

        }

        return list;

    }

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
