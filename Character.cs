using System;
using System.Security.Cryptography;
namespace pa2mis321
{
    public class Character
    {
        public string Name { get; set; }
        public int maxPower { get; set; }
        public double Health { get; set; }
        public double attackStrenth { get; set; }
        public double defensePower { get; set; }

        private IAttack attackBehavior {get; set;}

        public virtual void Attack()
        {
            System.Console.WriteLine("Attack");
        }

        public Character()
        {

        }

        public void SetPitchBehavior(IPitch pitchBehavior)
        {
            this.pitchBehavior = pitchBehavior;
        }

    }


}