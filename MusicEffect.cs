using Terraria;
using Terraria.ModLoader;

namespace AkiraIEoRMusic
{
    public abstract class MusicEffect : ModSceneEffect
    {
        public abstract bool Config { get; }

        public abstract string MusicName { get; }

        public override int Music
        {
            get => MusicLoader.GetMusicSlot(Mod, "Music/" + MusicName);
        }

        public override bool IsSceneEffectActive(Player player)
        {
            bool bossRushActive = false;
            if (ModLoader.TryGetMod("CalamityMod", out Mod cal))
                bossRushActive = cal.Call("GetDifficultyActive", "bossrush") is bool b && b;

            return !bossRushActive && Config && Active(player);
        }

        public abstract bool Active(Player player);
    }
}
