public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> d =new Dictionary<int,int>();
        List<int>[] r = new List<int>[nums.Length];
        foreach(int n in nums)
        {
            if(d.TryGetValue(n,out int c))
            {
                c++;
                d[n]=c;
            }
            else
            {
                d.Add(n,1);
            }
        }


        foreach (KeyValuePair<int, int> kvp in d)
        {
            if(r[kvp.Value-1]==null)
            {
                r[kvp.Value-1] = new List<int>();
            } 
            r[kvp.Value-1].Add( kvp.Key);
        }

        int l =r.Length-1;
        List<int> ret = new List<int>();
        List<int> v;
        int index=0;

        while(l>=0)
        {
            v= r[l--];
            if(v!=null)
            {
                foreach(int g in v)
                {
                    ret.Add( g);
                    if(ret.Count()==k)
                    break;
                }
         
            }
             if(ret.Count()==k)
                    break;
        }

        return ret.ToArray();

    }
}
