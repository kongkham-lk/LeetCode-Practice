class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
        strList = list(s)

        l, r = 0, len(strList) - 1
        while l < r:
            while (strList[l] not in vowels and l < r):
                l += 1
            while (strList[r] not in vowels and l < r):
                r -= 1
            strList[l], strList[r] = strList[r], strList[l]
            l += 1
            r -= 1
                
        return "".join(strList)

            