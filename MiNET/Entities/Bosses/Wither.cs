using MiNET.Worlds;

namespace MiNET.Entities.Bosses
{
    public class Wither : Boss
    {
        public Wither(Level level) : base(52, level)
        {
            HealthManager.MaxHealth = 1000;
            NameTag = "Wither"; //this will be displayed above the health bar
        }

        public override void SpawnEntity()
        {
            base.SpawnEntity();
        }
    }
}
