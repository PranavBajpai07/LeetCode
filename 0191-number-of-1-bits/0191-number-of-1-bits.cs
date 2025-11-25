public class Solution {
    public int HammingWeight(int n) {
    int count = 0;
    while (n > 0) {
        n &= (n - 1);   // removes the lowest 1
        count++;
    }
    return count;
    }

}