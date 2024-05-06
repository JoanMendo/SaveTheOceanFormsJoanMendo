using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanFormsJoanMendo.Classes
{
    internal class Player
    {
        private string name;

        private int score;
        private string profession;
        private int level;

        public Player(string name, int score, string profession, int level)
        {
            Name = name;
            Profession = profession;
            Score = score;
            Level = level;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public void ChangeScore(int points)
        {
            score += points;
        }


        public void IncreaseLevel()
        {
            level++;
        }
    }
}
