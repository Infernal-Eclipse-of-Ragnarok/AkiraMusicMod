using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace AkiraIEoRMusic.MusicEffects
{
    internal class Plantera : MusicEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh + 3;

        public override string MusicName => "Neurotoxin";

        public override bool Config => MusicConfig.Instance.Plantera;

        public override bool Active(Player player)
        {
            NPC closestBoss = MusicUtils.FindClosestBoss(NPCID.Plantera);
            return closestBoss != null && closestBoss.active;
        }
    }
}
