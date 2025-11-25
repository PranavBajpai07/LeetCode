public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0) return "";

        int minLen = int.MaxValue;
        foreach(string str in strs){
            if(str.Length < minLen){
                minLen = str.Length;
            }
        }

        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < minLen ; i++ ){
            char c = strs[0][i];

            for(int j = 1; j < strs.Length; j++){
                if(strs[j][i] != c){
                    return sb.ToString();
                }
            }

            sb.Append(c);
        }

        return sb.ToString();
    }
}