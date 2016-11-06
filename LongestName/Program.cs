using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LongestName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Users\abukalau\Desktop\LongestNameInput.txt");


            FindSportsmenWithLongestFullname(input);
            FindSportsmenWithLongestFullnameLikeAPro(input);
            SortSportsmenByFullnameLength(input);
        }


        public static void FindSportsmenWithLongestFullname(string input)
        {
            string[] names = input.Split(',');
            string longestName = "";


            for (var i = 0; i < names.Length; i++)
            {
                if (names[i].Trim().Length > longestName.Length)
                {
                    longestName = names[i];
                }
            }


            string output = "Longest name: " + longestName;


            File.WriteAllText(@"C:\Users\abukalau\Desktop\LongestNameV1.txt", output);
        }


        public static void FindSportsmenWithLongestFullnameLikeAPro(string input)
        {
            string[] namesArray = input.Split(',');
            List<string> names = namesArray.ToList();
            string longestName = names.OrderByDescending(name => name.Trim().Length).First();


            string output = "Longest name: " + longestName;


            File.WriteAllText(@"C:\Users\abukalau\Desktop\LongestNameV2.txt", output);
        }

        public static void SortSportsmenByFullnameLength(string input)
        {
            List<string> names = input.Split(',').ToList();
            names = names.OrderByDescending(x => x.Trim().Length).ToList();


            var output = String.Join(",", names);


            File.WriteAllText(@"C:\Users\abukalau\Desktop\sortedNames.txt", output);
        }
    }
}





