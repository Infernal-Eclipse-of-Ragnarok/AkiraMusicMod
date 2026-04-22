using AkiraIEoRMusic.Utils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AkiraIEoRMusic.MusicEffects
{
    internal class MoonLord : MusicEffect
    {
        public override SceneEffectPriority Priority => (SceneEffectPriority)8;

        public override string MusicName => "GUARDIAN";

        public override bool Config => MusicConfig.Instance.MoonLord;

        public override bool Active(Player player) => MusicUtils.FindClosestBoss(NPCID.MoonLordCore) != null;
    }
}
