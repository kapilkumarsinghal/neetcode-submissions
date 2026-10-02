public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> countT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        // Initialize countT with characters from t
        foreach (char c in t) {
            if (countT.ContainsKey(c)) {
                countT[c]++;
            } else {
                countT[c] = 1;
            }
        }

        int need = countT.Count;
        int have = 0;
        int l = 0;
        int resLen = s.Length + 1;
        int resStart = 0;

        for (int r = 0; r < s.Length; r++) {
            char c = s[r];
            if (window.ContainsKey(c)) {
                window[c]++;
            } else {
                window[c] = 1;
            }

            if (countT.ContainsKey(c) && window[c] == countT[c]) {
                have++;
            }

            while (have == need) {
                if (r - l + 1 < resLen) {
                    resLen = r - l + 1;
                    resStart = l;
                }

                char leftChar = s[l];
                window[leftChar]--;
                if (countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]) {
                    have--;
                }
                l++;
            }
        }

        return resLen == s.Length + 1 ? "" : s.Substring(resStart, resLen);
    }
}
