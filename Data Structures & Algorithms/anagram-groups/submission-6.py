class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        group_dict = defaultdict(list)

        for s in strs:
            freq_list = [0]*26

            for ch in s:
                index = ord(ch) - ord('a')
                freq_list[index] += 1
            
            key = tuple(freq_list)
            group_dict[key].append(s)

        
        return list(group_dict.values())
            

