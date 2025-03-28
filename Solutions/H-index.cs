//Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.

//According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.
// [3,0,6,1,5] => 3
using System;

public class Solution5 {
    public int HIndex(int[] citations) {
        int n = citations.Length;
        int[] counts = new int[n + 1];

        // Count the number of citations for each value (clamped at n)
        foreach (int citation in citations) {
            counts[Math.Min(citation, n)]++;
        }

        int hIndex = 0;
        for (int i = n; i >= 0; i--) {
            hIndex += counts[i]; // Accumulate the count
            if (hIndex >= i) {
                return i; // The highest h-index found
            }
        }
        return 0;
    }
}