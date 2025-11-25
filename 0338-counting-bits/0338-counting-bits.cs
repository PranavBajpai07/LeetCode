public class Solution {
    public int[] CountBits(int n)
{
    int[] ans = new int[n + 1];

    for (int i = 0; i <= n; i++)
    {
        ans[i] = CountOnes(i);
    }

    return ans;
}

private int CountOnes(int x)
{
    int count = 0;
    while (x > 0)
    {
        x &= (x - 1);
        count++;
    }
    return count;
}

}