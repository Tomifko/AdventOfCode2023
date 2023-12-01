using AdventOfCode2023;

#region Day 01
using System.Text.RegularExpressions;

string input = PuzzleInputs.Input01;
string[] inputArray = input.Split("\r\n");

int part1solution = 0;

foreach(string line in inputArray)
{
    var firstDigit = Regex.Match(line, @"\d+").Value.First().ToString();
    var lastDigit = Regex.Match(line, @"(\d+)(?!.*\d)").Value.Last().ToString();

    part1solution += int.Parse(firstDigit + lastDigit);
}
Console.WriteLine("Day 01, Part I solution: " + part1solution);


input = input.Replace("one", "on1e");
input = input.Replace("two", "tw2o");
input = input.Replace("three", "thr3ee");
input = input.Replace("four", "fo4ur");
input = input.Replace("five", "fi5ve");
input = input.Replace("six", "si6x");
input = input.Replace("seven", "sev7en");
input = input.Replace("eight", "eig8ht");
input = input.Replace("nine", "ni9ne");

int part2solution = 0;
inputArray = input.Split("\r\n");
foreach (string line in inputArray)
{
    var firstDigit = Regex.Match(line, @"\d+").Value.First().ToString();
    var lastDigit = Regex.Match(line, @"(\d+)(?!.*\d)").Value.Last().ToString();

    int sum = int.Parse(firstDigit + lastDigit);
    part2solution += sum;
}
Console.WriteLine("Day 01, Part I solution: " + part2solution);









//for (int i = 0; i < inputArray.Length; i++)
//{
//    for (int j = 0; j < inputArray[i].Length; j++)
//    {
//        if (char.IsDigit(inputArray[i][j]))
//        {

//        }
//    }
//}

Console.ReadLine();
#endregion