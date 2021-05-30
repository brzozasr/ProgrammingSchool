using System;

namespace ProgrammingSchool.Utilities
{
    public static class Util
    {
        public static Random Random => new Random();

        public static string GetRandomName()
        {
            var gender = Random.Next(0, 2);

            if (gender == 0)
            {
                var maleName = Random.Next(0, NameMaleList.NameMale.Length);
                var maleLastName = Random.Next(0, LastNameMaleList.LastNameMale.Length);

                return $"{NameMaleList.NameMale[maleName]} {LastNameMaleList.LastNameMale[maleLastName]}";
            }
            else
            {
                var femaleName = Random.Next(0, NameFemaleList.NameFemale.Length);
                var femaleLastName = Random.Next(0, LastNameFemaleList.LastNameFemale.Length);

                return $"{NameFemaleList.NameFemale[femaleName]} {LastNameFemaleList.LastNameFemale[femaleLastName]}";
            }
        }

        public static string GetRandomPhoneNo()
        {
            var part1 = Random.Next(500, 800);
            var part2 = Random.Next(0, 1000);
            var part3 = Random.Next(0, 1000);

            return $"+48 {part1} {part2:#000} {part3:#000}";
        }

        public static DateTime GetRandomBirthday()
        {
            var randomDays = Random.Next(7300, 16200);
            return DateTime.Today.AddDays(-randomDays);
        }
        
        public static double SalaryGenerator(this Random random, double min, double max)
        {
            return Math.Round(random.NextDouble() * (max - min) + min, 2,
                MidpointRounding.AwayFromZero);
        }
    }
}