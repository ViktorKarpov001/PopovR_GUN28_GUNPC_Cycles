namespace PopovR_GUN28_Classes
{
    public class Weapon
    {
        public string Name { get; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public float Durability { get; } = 1f;

        public Weapon(string name = "Weapon")
        {
            Name = name;
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage) 
        {
            minDamage = 1;
            maxDamage = 10;
            if (minDamage < 1)
            {
                minDamage = 1;
                Console.WriteLine("Forced setting of the minimum value");
            }

            else if (maxDamage <= 1)
            {
                maxDamage = 10;
            }
        }

        public int GetDamage() 
        {
            int averageDamage = (MaxDamage - MinDamage) / 2;
            return averageDamage;
        }
    }
}
