using Terraria.ModLoader;
using Terraria;

namespace AkiraIEoRMusic.MusicEffects
{
    internal class Pillars2 : MusicEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

        public override string MusicName => "SPAWN";

        public override bool Config => MusicConfig.Instance.Pillars;

        public override bool Active(Player player)
        {
            int num = MusicUtils.CountPillars();
            return num > 0 && num <= 2;
        }
    }
}
