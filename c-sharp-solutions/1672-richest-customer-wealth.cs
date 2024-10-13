public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxvalue = int.MinValue;
        for(int i=0; i<accounts.Length; i++)
        {
            if(accounts[i].Sum() > maxvalue)
            {
                maxvalue = accounts[i].Sum();
            }
        }
        return maxvalue;
    }
}
