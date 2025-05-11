class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
        strList = list(s)

        l = 0
        r = len(strList) - 1
        while l < r:
            if strList[l] in vowels and strList[r] in vowels:
                strList[l], strList[r] = strList[r], strList[l]
                l += 1
                r -= 1
            elif (strList[l] not in vowels):
                l += 1
            elif (strList[r] not in vowels):
                r -= 1
                
        return "".join(strList)

            