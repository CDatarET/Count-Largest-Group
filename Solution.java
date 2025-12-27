class Solution {
    private int sum(int n){
        int ret = 0;
        while(n > 0){
            ret = ret + (n % 10);
            n = n / 10;
        }

        return(ret);
    }
        
    public int countLargestGroup(int n) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        int max = 0;
        for(int i = 1; i <= n; i++){
            int num = sum(i);
            map.put(num, map.getOrDefault(num, 0) + 1);
            max = Math.max(max, map.get(num));
        }

        int g = 0;
        for(int i : map.values()){
            if(i == max){
                g++;
            }
        }

        return(g);
    }
}
