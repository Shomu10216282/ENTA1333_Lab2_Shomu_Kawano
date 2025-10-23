using System;

namespace GD13_1333_Shomu.Scripts
{
    internal class Potion : Item
    {
        private int minHeal;
        private int maxHeal;
        private Random rand = new Random();

        public Potion(string name, int minHeal, int maxHeal) : base(name, $"{minHeal}d{maxHeal} heal (random)")
        {
            this.minHeal = minHeal;
            this.maxHeal = maxHeal;
        }

        public override void Use(Player player)
        {
            int heal = rand.Next(minHeal, maxHeal + 1);
            player.Heal(heal);
        }

        public override bool IsConsumable() => true;
    }
}
