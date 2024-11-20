using Items;
using Units;

namespace Dungeon;

public sealed class LootRoom: Room
{
    private Item Loot { get; }
    
    public LootRoom(string name, Item item) : base(name)
    {
        Loot = item;
    }
    
    public override void RunEncounter(Player player, out bool success)
    {
        Console.WriteLine($"Entered room {Name}");
        
        player.PickItem(Loot);
        success = true;
    }
}