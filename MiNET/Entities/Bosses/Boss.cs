using MiNET.Worlds;
using MiNET.Net;

namespace MiNET.Entities.Bosses
{
    public class Boss : Entity
    {
        public Boss(int entityTypeId, Level level) : base(entityTypeId, level)
        {
        }

        public override void SpawnEntity()
        {
            base.SpawnEntity();
            SendAll(); //just in case
        }

        public override void SpawnToPlayers(Player[] players)
        {
            base.SpawnToPlayers(players);
            SendAll(); //just in case
        }

        public virtual void SendBossEvent()
        {
            var BossEvent = McpeBossEvent.CreateObject();
            BossEvent.WriteSignedVarLong(EntityId);
            BossEvent.WriteSignedVarLong(EntityId);
            //package.Encode(); 
            Level.RelayBroadcast(BossEvent);
        }

        protected void SendAll()
        {
            SendUpdateAttributes();
            SendBossEvent();
        }
    }
}
