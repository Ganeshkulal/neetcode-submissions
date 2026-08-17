public class Solution {
    public bool IsPalindrome(string s) {
        int lp=0, rp=s.Length-1;
        while(lp<rp &rp>0)
        {
            while(!Char.IsLetterOrDigit(s[lp]) && lp<rp)
            {
                lp++;
            }
             while(!Char.IsLetterOrDigit(s[rp] )&& lp<rp)
            {
                rp--;
            }

            if(lp<rp && Char.ToLower(s[lp++])!= Char.ToLower(s[rp--]))
            return false;
        }
        return true;
    }
}
