using System;

namespace HW14
{
    class HW14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Final Score");
            int Team1 = 99;
            int Team2 = 100;
            Console.WriteLine(Team1);
            Console.WriteLine(Team2);
            Console.ReadLine();

            string TeamOne = "Team One Scored 99";
            string TeamTwo = "Team two Scored 100, Team two wins";
            Console.WriteLine(TeamOne);
            Console.WriteLine(TeamTwo);
            Console.ReadLine();

            float FirstTeam = 0.68f;
            float SecondTeam = 0.67f;
            Console.WriteLine(FirstTeam);
            Console.WriteLine(SecondTeam);
            Console.ReadLine();

            double more = 0.1;
            Console.WriteLine(more);
            Console.ReadLine();

            bool TeamNum1 = false;
            bool TeamNum2 = true;
            Console.WriteLine(TeamNum1);
            Console.WriteLine(TeamNum2);
            Console.ReadLine();

            Console.WriteLine("Team one, with a score of {0}, lost to Team two, with a score of {1}. Team two shot {2} percent more beyond the arch.", Team1, Team2, more);
            Console.ReadKey();

            Console.Write("Does Team Two Go To The Finals?");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadKey();

            Console.WriteLine(99 < 100);
            Console.WriteLine(68 < 67);
            Console.WriteLine("Team1" != "Finals");
            Console.WriteLine("Team2" == "Finals");
            Console.ReadKey();
        }
    }
}
