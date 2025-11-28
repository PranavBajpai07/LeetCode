public class Solution {
    public int ReverseBits(int n) {
        uint num = (uint)n;   // convert signed int → uint

        uint res = 0;
        for (int i = 0; i < 32; i++) {
            res = (res << 1) | (num & 1);
            num >>= 1;
        }

        return (int)res;      // convert back to int
    }
}
