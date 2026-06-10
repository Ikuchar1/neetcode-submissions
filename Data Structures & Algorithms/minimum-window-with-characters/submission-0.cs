public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> required = new Dictionary<char, int>();

        int left = 0;
        int right = 0;

        char[] sChars = s.ToCharArray();
        char[] tChars = t.ToCharArray();

        char c;

        for(int i = 0; i < t.Length; i++){
            //see if dict contains it
            c = tChars[i];
            if(!required.ContainsKey(c)){
                required.Add(c, 1);
            } else {
                required[c]++;
            }
        }


        //start the window
        Dictionary<char,int> window = new Dictionary<char,int>();
        int have = 0;

        int resLen = int.MaxValue;
        int resStart = 0;
        char rightChar;

        while(right < sChars.Length){
            rightChar = sChars[right];

            //add rChar to window
            if(!window.ContainsKey(rightChar)){
                window.Add(rightChar, 1);
            }else{
                window[rightChar]++;
            }

            //check to see if rightChar is a required char
            if(required.ContainsKey(rightChar) && window[rightChar] == required[rightChar]){
                have++;
            }

            while(have == required.Count){
                //set min
                int windowSize = right - left + 1;   // how big is the current window
                if(windowSize < resLen){             // is it smaller than the best so far?
                    resLen = windowSize;             // yes → this is the new best length
                    resStart = left;                 // and remember where it started
                }

                //remove leftChar from window
                char leftChar = sChars[left];
                window[leftChar]--;
                if(required.ContainsKey(leftChar) && window[leftChar] < required[leftChar]){
                    have--;
                }

                left++;
                
            }

            right++;
        }


        return resLen == int.MaxValue ? "" : s.Substring(resStart, resLen);


    }
}
