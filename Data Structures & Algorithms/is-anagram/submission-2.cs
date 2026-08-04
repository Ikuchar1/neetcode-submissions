public class Solution {
    public bool IsAnagram(string s, string t) {
        //go thru first string
        //make dictionary
        //

        Dictionary<char, int> string1 = new Dictionary<char, int>();
        Dictionary<char, int> string2 = new Dictionary<char, int>();

        char c1;
        char c2;

        if (s.Length != t.Length){
            return false;
        }

        for (int i = 0; i < s.Length; i++){
            c1 = s[i];
            c2 = t[i];

            if(!string1.ContainsKey(c1)){
                string1.Add(c1, 1);
            } else {
                string1[c1]++;
            }

            if(!string2.ContainsKey(c2)){
                string2.Add(c2, 1);
            } else {
                string2[c2]++;
            }
        }

        //make sure the dictionaryies are the same
        foreach (var (key, value) in string1){
            Console.WriteLine($"{key} = {value}");

            if((!string2.ContainsKey(key)) || (string2[key] != string1[key])){
                return false;
            }

        }

        return true;

        
    }
}
