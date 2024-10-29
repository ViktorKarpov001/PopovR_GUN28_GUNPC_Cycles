namespace PopovR_GUN28_Classes
{
    public class Unit
    {
        public string Name { get; }
        private float _health;
        public float Health => _health;
        public float _armor;
        public int _damage;
        

        public Unit() : this(name: "Unknown Unit") { }

        public Unit(string name) => Name = name;
        

        public int Damage
        {
            get { return _damage = 5; }
        }

        public float Armor 
        { 
            get { return _armor = 0.6f; }
        }

        public float GetRealHealth() => Health * (1f + Armor);

        public bool SetDamage(float setDamage)
        {
            setDamage = Health - 1f * Armor;

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

