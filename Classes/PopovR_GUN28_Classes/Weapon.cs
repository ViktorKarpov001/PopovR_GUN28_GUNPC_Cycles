namespace PopovR_GUN28_Classes
{
    public class Weapon
    {
        public string Name { get; }
        public int _minDamage { get; private set; }
        public int _maxDamage { get; private set; }
        public float _durability { get; }

        public Weapon(string name = "Weapon")
        {
            Name = name;
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage) 
        {
            int f = 1;
            if (minDamage < 1)
            {
                minDamage = f;
                Console.WriteLine("Forced setting of the minimum value");
            }
            
            else if (maxDamage <= 1) 
            { 
                maxDamage = 10;
            }

            if (minDamage > maxDamage)
            {
                var swapDamage = minDamage;
                minDamage = maxDamage;
                maxDamage = swapDamage;
            }
            return;
        }

        public void GetDamage() 
        {
            SetDamageParams(_minDamage, _maxDamage);
            int averageDamage = _minDamage + _maxDamage;
            Console.WriteLine("The arithmetic mean of the entered numbers = " + (int)averageDamage / 2);
        }
    }
}
