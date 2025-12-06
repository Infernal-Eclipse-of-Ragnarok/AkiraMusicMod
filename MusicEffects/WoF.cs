using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AkiraIEoRMusic.MusicEffects
{
    internal class WoF : MusicEffect
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return false;
            return ModLoader.HasMod("UnCalamityModMusic");
        }

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh + 4;

        public override string MusicName => "";

        public override int Music
        {
            get => MusicLoader.GetMusicSlot("UnCalamityModMusic/Assets/Music/Bosses/WallofFlesh");
        }

        public override bool Config => false; //MusicConfig.Instance.VanillaCalamityWoF;

        public override bool Active(Player player) => MusicUtils.FindClosestBoss(NPCID.WallofFlesh) != null;
    }
}
