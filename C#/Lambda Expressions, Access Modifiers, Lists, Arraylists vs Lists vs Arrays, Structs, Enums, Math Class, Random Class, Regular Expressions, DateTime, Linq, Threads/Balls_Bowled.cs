using System;
using System.Collections.Generic;
using System.Linq;

namespace BallsBowled
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of overs"); 
            var overCount = int.Parse(Console.ReadLine()); 
            var bowler = new PlayerBO(); 
            bowler.AddOversDetails (overCount);
            Console.WriteLine($"Balls Bowled: {bowler.GetNoOfBallsBowled()}");
        }
    }
    public class PlayerBO
    {
        public List<int> PlayerList { get; set; } = new List<int>();
        public void AddOversDetails (int oversBowled)
        {
            PlayerList.Add(oversBowled);
        }
        public int GetNoOfBallsBowled ()
        {
            var totalOver = PlayerList.Sum((over) => over);
            return totalOver*6;
        }
    }
}