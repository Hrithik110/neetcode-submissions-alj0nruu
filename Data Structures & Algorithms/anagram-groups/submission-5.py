class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        group_dict = {}

        for i, s in enumerate(strs):
            freq_list = [0]*26

            for ch in s:
                index = ord(ch) - ord('a')
                freq_list[index] += 1
            
            key = "-".join(map(str, freq_list))

            if key not in group_dict:
                group_dict[key] = []
            group_dict[key].append(s)

        
        return list(group_dict.values())
            

