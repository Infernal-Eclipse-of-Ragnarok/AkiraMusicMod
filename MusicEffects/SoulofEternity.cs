using AkiraIEoRMusic.Utils;
using Terraria;
using Terraria.ModLoader;

namespace AkiraIEoRMusic.MusicEffects
{
    [ExtendsFromMod("FargowiltasSouls")]
    [JITWhenModsEnabled("FargowiltasSouls")]
    internal class SoulofEternity : MusicEffect
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return !ModLoader.HasMod("Selentia");
        }

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh + 1;

        public override string MusicName => "EndofStory";

        public override bool Config => MusicConfig.Instance.SoulofEternityInterlude;

        public override bool Active(Player player)
        {
            return FargosCompatability.SoEEquiped(player);
        }
    }
}
