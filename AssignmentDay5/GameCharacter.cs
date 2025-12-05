using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    internal class GameCharacter
    {
        public int Health {  get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public string[] Skills {  get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}, Attack: {Attack}, Defense: {Defense}");
            Console.WriteLine("Skills: " + string.Join(", ", Skills));
            Console.WriteLine();
        }

    }
}
