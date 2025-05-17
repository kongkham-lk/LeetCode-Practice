class WordDictionary:

    def __init__(self):
        self.words = []

    def addWord(self, word: str) -> None:
        self.words.append(word)

    def search(self, word: str) -> bool:
        if '.' not in word:
            return word in self.words
        else:
            for p in self.words:
                if len(p) != len(word):
                    continue
                
                i = 0
                while i < len(word):
                    if p[i] == word[i] or word[i] == '.':
                        i += 1
                    else:
                        break
                    if i == len(word):
                        return True
            return False
        

# Your WordDictionary object will be instantiated and called as such:
# obj = WordDictionary()
# obj.addWord(word)
# param_2 = obj.search(word)