public class Solution {
    private int sum(int n){
        int ret = 0;
        while(n > 0){
            ret = ret + (n % 10);
            n = n / 10;
        }

        return(ret);
    }
        
    public int CountLargestGroup(int n) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        int max = 0;
        for(int i = 1; i <= n; i++){
            int num = sum(i);
            if(d.ContainsKey(num)) d[num]++;
            else d[num] = 1;
            max = Math.Max(max, d[num]);
        }

        int g = 0;
        foreach(var value in d.Values){
            if(value == max) g++;
        }

        return(g);
    }
}
