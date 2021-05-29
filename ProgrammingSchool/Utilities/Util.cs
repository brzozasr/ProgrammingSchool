using System;

namespace ProgrammingSchool.Utilities
{
    public class Util
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
    }
}