class Solution:
    def add(self, n):
        ret = 0
        while n > 0:
            ret += n % 10
            n //= 10
        
        return ret
        
    def countLargestGroup(self, n):
        d = {}
        m = 0
        for i in range(1, n + 1):
            num = self.add(i)
            if num in d: d[num] += 1
            else: d[num] = 1
            m = max(m, d[num])
        
        g = 0
        for x in d:
            if d[x] == m: g += 1
        
        return g
