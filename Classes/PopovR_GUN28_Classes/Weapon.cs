namespace PopovR_GUN28_Classes
{
    public class Weapon
    {
        public string Name { get; }
        private int _minDamage;
        private int _maxDamage;
        public float Durability { get; }

        public int MinDamage
        {
            get => _minDamage;
            private set => _minDamage = value;
        }

        public int MaxDamage
        {
            get => _maxDamage;
            private set => _maxDamage = value;
        }

        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        private void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                (minDamage, maxDamage) = (maxDamage, minDamage);
                Console.WriteLine($"Некорректные входные данные для оружия '{Name}': _minDamage больше _maxDamage.");
            }

            if (minDamage < 1)
            {
                MinDamage = 1;
                Console.WriteLine($"Форсированная установка минимального значения для оружия '{Name}'.");
            }
            else
            {
                MinDamage = minDamage;
            }

            MaxDamage = maxDamage <= 1 ? 10 : maxDamage;
        }

        public int GetDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }
    }
}
