using Terraria;
using Terraria.ModLoader;

namespace AkiraIEoRMusic.MusicEffects
{
    internal class Pillars1 : MusicEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

        public override string MusicName => "SPAWN";

        public override bool Config => MusicConfig.Instance.Pillars;

        public override bool Active(Player player)
        {
            return MusicUtils.CountPillars() > 2;
        }
    }
}
