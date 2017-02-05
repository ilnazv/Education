// https://trello.com/c/zVOWCkeI/282-the-chosen-one

using System;
using System.IO;

namespace Algorithms.ChosenOne
{
    public static class ChosenOneSolutionExample
    {
        public static void Run()
        {
            //var binPath = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory);
            //var rootPath = binPath.Parent.Parent.FullName;
            //var inputPath = Path.Combine(rootPath, @"chosenone\input.txt");
            //var inputString = "";
            //using (StreamReader sr = new StreamReader(inputPath))
            //{
            //    inputString = sr.ReadToEnd();
            //}

            //var arrString = inputString.Split(' ');
            //var integers = Array.ConvertAll(arrString, Int64.Parse);

            var testIntegers = new long[]{3, 6, 18, 12};

            var result = ChosenOne.GetDividerExceptOneNumber(testIntegers.Length, testIntegers);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
