using System;

namespace BasketManagerApp.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Number { get; set; }
        public double PointsPerGame { get; set; }

        public Player(int id, string name, string position, int number, double ppg)
        {
            Id = id;
            Name = name;
            Position = position;
            Number = number;
            PointsPerGame = ppg;
        }
    }
}