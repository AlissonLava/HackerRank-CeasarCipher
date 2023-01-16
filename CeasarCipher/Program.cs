using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {

        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string rotatedAlphabet = alphabet.Substring(k, alphabet.Length - k) + alphabet.Substring(0, k);
        string result = "";

        for (int iS = 0; iS < s.Length; iS++)
        {
            string sLeter = s.Substring(iS, 1);

            for (int iA = 0; iA < alphabet.Length; iA++)
            {
                string aLeter = alphabet.Substring(iA, 1);

                if (sLeter == aLeter){
                    sLeter = rotatedAlphabet.Substring(iA, 1);
                    break;
                }
                if (sLeter == aLeter.ToUpper()){
                    sLeter = rotatedAlphabet.Substring(iA, 1).ToUpper();
                    break;
                }
            }

            result += sLeter;
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        Console.WriteLine(result);
    }
}
