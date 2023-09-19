using System;
using System.IO;
using System.Globalization;
using System.Text;

class Program
{
    static string CapitalizeWords<T>(T input)
    {
        string text = input.ToString();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = textInfo.ToTitleCase(words[i]);
        }

        return string.Join(" ", words);
    }

    static void Main()
    {
        string inputFileName = "C:\\Users\\enzo.nguyen\\source\\repos\\EventSystem\\Convert\\input.txt";
        string outputFileName = "C:\\Users\\enzo.nguyen\\source\\repos\\EventSystem\\Convert\\output.txt";

        try
        {
            string inputContent = File.ReadAllText(inputFileName);

            string capitalizedContent = CapitalizeWords(inputContent);

            File.WriteAllText(outputFileName, capitalizedContent);

            Console.WriteLine("File processing complete. Check 'output.txt' for the result.");
            Console.ReadKey();
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
