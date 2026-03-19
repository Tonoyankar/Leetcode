using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        Dictionary<char, int> seen = new Dictionary<char, int>();

        int leftIndex = 0, maxLength = 0;

        for (int rightIndex = 0; rightIndex < s.Length; rightIndex++)
        {
            char currentChar = s[rightIndex];

            if (seen.ContainsKey(currentChar) && seen[currentChar] >= leftIndex)
            {
                leftIndex = seen[currentChar] + 1;
            }
            seen[currentChar] = rightIndex;

            maxLength = Math.Max(rightIndex - leftIndex + 1, maxLength);
        }
        return maxLength;
    }
}