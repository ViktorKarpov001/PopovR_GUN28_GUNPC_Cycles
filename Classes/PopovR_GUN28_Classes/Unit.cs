namespace PopovR_GUN28_Classes
{
    public class Unit
    {
        public string Name { get; }
        private float Health { get; }
        private int _damage { get; }
        public int _minDamage { get; private set; }
        public int _maxDamage { get; private set; }
        public Weapon _weapon;

        public Unit() : this(name: "Unknown Unit") { }

        public Unit(string name)
        {
            Name = name;
        }

        public int Damage(int damage = 5)
        {
            return Damage(damage);
        }

        public float Armor(float armor = 0.6f)
        {
            return Armor(armor);
        }

        public float GetRealHealth() 
        {
            return Health * (1f * Armor());
        }

        public bool SetDamage(float setDamage)
        {
            setDamage = Health - 1f * Armor();

            if (Health <= 0f)
            {
                return true;
            }
            else if (Health > 0f)
            {
                return false;
            }
            return false;
        }

    }
    
}

