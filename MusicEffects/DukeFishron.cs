using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AkiraIEoRMusic.MusicEffects
{
    internal class DukeFishron : MusicEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh + 5;

        public override string MusicName => "SewerCreatureCut";

        public override bool Config => MusicConfig.Instance.DukeFishron;

        public override bool Active(Player player)
        {
            NPC closestBoss = MusicUtils.FindClosestBoss(NPCID.DukeFishron);
            return closestBoss != null && closestBoss.active;
        }
    }
}
