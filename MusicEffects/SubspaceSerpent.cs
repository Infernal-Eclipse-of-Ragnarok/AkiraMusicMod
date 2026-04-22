using AkiraIEoRMusic.Utils;
using SOTS.NPCs.Boss;
using Terraria;
using Terraria.ModLoader;

namespace AkiraIEoRMusic.MusicEffects
{
    [JITWhenModsEnabled("SOTS")]
    [ExtendsFromMod("SOTS")]
    internal class SubspaceSerpent : MusicEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh + 5;

        public override string MusicName => "Isolation";

        public override bool Config => MusicConfig.Instance.SubspaceSerpent;

        public override bool Active(Player player)
        {
            NPC closestBoss = MusicUtils.FindClosestBoss(ModContent.NPCType<SubspaceSerpentHead>());
            return closestBoss != null && closestBoss.active;
        }
    }
}
