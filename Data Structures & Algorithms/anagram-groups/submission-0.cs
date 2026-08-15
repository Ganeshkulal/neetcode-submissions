public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        int[] alpha = new int[26];
        Dictionary<string,List<string>> d = new  Dictionary<string,List<string>>();
        for (int i=0;i<strs.Length;i++)
        {
            string word = strs[i];
            alpha = new int[26];
           for(int j=0;j<word.Length;j++)
           {
            alpha[word[j]-'a']++;
           }
           string key ="";
           for (int a=0;a<alpha.Length;a++)
           {
            key+=alpha[a]+',';
           }
           if(d.TryGetValue(key,out List<string> val))
           {
                val.Add(word);
           }
           else
           {
            d.Add(key,new List<string>{word});
           }


        }
        return d.Values.ToList();
    }


}
