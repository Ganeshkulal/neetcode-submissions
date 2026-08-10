public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] f = new int[100];
        int[] f1 = new int[100];

        if(s.Length == t.Length)
        {
        for (int i=0 ; i<s.Length;i++)
        {
            f[((int)s[i])-65]++;
             f1[((int)t[i])-65]++;

        }
        for (int i=0 ; i<f.Length;i++)
        {
            if(f[i]!=f1[i])
            return false;
            

        }
return true;
        }
        else
        return false;

    }
}
