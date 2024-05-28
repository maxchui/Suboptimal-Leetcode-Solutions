// URL: https://leetcode.com/problems/integer-to-english-words/
// Time Complexity: O(log(n))
// Space Complexity: O(log(n))

public class Solution
{
    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return "Zero";
        }

        return ConvertToWords(num).Trim();
    }

    private string ConvertToWords(int num)
    {
        if (num == 0) return "";

        if (num < 10) return One(num);
        if (num < 20) return TwoLessThan20(num);
        if (num < 100) return Tens(num);
        if (num < 1000) return Hundreds(num);

        if (num < 1000000)
        {
            return ConvertToWords(num / 1000) + " Thousand " + ConvertToWords(num % 1000);
        }

        if (num < 1000000000)
        {
            return ConvertToWords(num / 1000000) + " Million " + ConvertToWords(num % 1000000);
        }

        return ConvertToWords(num / 1000000000) + " Billion " + ConvertToWords(num % 1000000000);
    }

    private string One(int num)
    {
        switch (num)
        {
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            default: return "";
        }
    }

    private string TwoLessThan20(int num)
    {
        switch (num)
        {
            case 10: return "Ten";
            case 11: return "Eleven";
            case 12: return "Twelve";
            case 13: return "Thirteen";
            case 14: return "Fourteen";
            case 15: return "Fifteen";
            case 16: return "Sixteen";
            case 17: return "Seventeen";
            case 18: return "Eighteen";
            case 19: return "Nineteen";
            default: return "";
        }
    }

    private string Tens(int num)
    {
        int tenner = num / 10;
        int rest = num % 10;

        switch (tenner)
        {
            case 2: return "Twenty" + (rest > 0 ? " " + One(rest) : "");
            case 3: return "Thirty" + (rest > 0 ? " " + One(rest) : "");
            case 4: return "Forty" + (rest > 0 ? " " + One(rest) : "");
            case 5: return "Fifty" + (rest > 0 ? " " + One(rest) : "");
            case 6: return "Sixty" + (rest > 0 ? " " + One(rest) : "");
            case 7: return "Seventy" + (rest > 0 ? " " + One(rest) : "");
            case 8: return "Eighty" + (rest > 0 ? " " + One(rest) : "");
            case 9: return "Ninety" + (rest > 0 ? " " + One(rest) : "");
            default: return "";
        }
    }

    private string Hundreds(int num)
    {
        int hundred = num / 100;
        int rest = num % 100;

        if (hundred != 0 && rest != 0)
        {
            return One(hundred) + " Hundred " + ConvertToWords(rest);
        }
        else if (hundred != 0)
        {
            return One(hundred) + " Hundred";
        }
        else
        {
            return ConvertToWords(rest);
        }
    }
}
