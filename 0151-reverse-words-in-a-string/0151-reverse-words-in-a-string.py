class Solution:
    def reverseWords(self, s: str) -> str:
        words = s.split()
        res = []
        i = len(words)-1

        while i >= 0:
            res.append(words[i])
            i = i - 1
            
        return ' '.join(res).strip()
