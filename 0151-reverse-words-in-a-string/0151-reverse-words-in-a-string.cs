public class Solution {
    public string ReverseWords(string s) {
        if( string.IsNullOrWhiteSpace(s)) {
            return string.Empty; // Retrun empty string if input is empty or only spaces
        }

        char[] chars = s.ToCharArray();

        Reverse(chars, 0, chars.Length - 1);

        ReverseEachWord(chars);

        return CleanSpaces(chars);

    }

    private void Reverse(char[] chars, int left, int right) {
        while(left < right) {
            char temp = chars[left];
            chars[left++] = chars[right];
            chars[right--] = temp;
        }
    }

    private void ReverseEachWord(char[] chars) {
        int n = chars.Length;
        int start = 0, end = 0;

        while (start < n) {
            while (start < n && chars[start] == ' ') start++;
            end = start;
            while (end < n && chars[end] != ' ') end++;
            Reverse(chars, start, end - 1);
            start = end;
        }
    }

    private string CleanSpaces(char[] chars) {
        int n = chars.Length;
        int i = 0, j = 0;

        while (j < n){
            while (j < n && chars[j] == ' ') j++;
            while (j < n && chars[j] != ' ') chars[i++] = chars[j++];
            while (j < n && chars[j] == ' ') j++;
            if (j < n) chars[i++] = ' ';
        }

        return new string(chars, 0, i);
    }
}