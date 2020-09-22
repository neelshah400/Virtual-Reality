using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuiz
{
    class Character
    {

        private string name;
        private string type; // "class"
        private int xp;

        public int Level
        {
            get
            {
                return 1 + (int)((double) xp / 1000.0);
            }
        }

        public Character((string, string) attributes)
        {
            name = attributes.Item1;
            type = attributes.Item2;
            xp = 0;
        }

        public void AddXP(int delta)
        {
            xp += delta;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\tClass: {1}\tXP: {2}", name, type, xp);
        }

    }
}
