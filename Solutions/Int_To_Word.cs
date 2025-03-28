using System;

public class Solution2
{
    public static string NumberToWords(int num)
    {
        if (num == 0) return "Zero";
        return Helper(num);
    }

    static string Helper(int num)
    {

      string[] belowTen = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
      string[] belowTwenty = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
      string[] belowHundred = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    string result = string.Empty;
        if (num < 10) result = belowTen[num];
        else if (num < 20) result = belowTwenty[num - 10];
        else if (num < 100) result = belowHundred[num / 10] + " " + Helper(num % 10);
        else if (num < 1000) result = Helper(num / 100) + " Hundred " + Helper(num % 100);
        else if (num < 1000000) result = Helper(num / 1000) + " Thousand " + Helper(num % 1000);
        else if (num < 1000000000) result = Helper(num / 1000000) + " Million " + Helper(num % 1000000);
        else result = Helper(num / 1000000000) + " Billion " + Helper(num % 1000000000);
        return result.Trim();
    }

    static void Main()
    {
        //Solution solution = new Solution();

        Console.WriteLine(NumberToWords(123));  // Output: "One Hundred Twenty Three"
        Console.WriteLine(NumberToWords(12345));  // Output: "Twelve Thousand Three Hundred Forty Five"
        Console.WriteLine(NumberToWords(1234567));  // Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
        Console.WriteLine(NumberToWords(1234567891));  // Output: "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One"
    }
}

