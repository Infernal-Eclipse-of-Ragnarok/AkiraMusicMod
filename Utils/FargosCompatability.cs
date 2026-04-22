using FargowiltasSouls;
using FargowiltasSouls.Content.Items.Accessories.Souls;
using FargowiltasSouls.Core.Systems;
using Terraria;
using Terraria.ModLoader;

namespace AkiraIEoRMusic.Utils
{
    [ExtendsFromMod("FargowiltasSouls")]
    [JITWhenModsEnabled("FargowiltasSouls")]
    public class FargosCompatability
    {
        public static bool downedMutant = WorldSavingSystem.DownedMutant;

        public static bool SoEEquiped(Player player)
        {
            Mod mod;
            bool flag = false;
            int num1 = 0, num2 = 0;

            if (ModLoader.TryGetMod("CalamityMod", out mod))
            {
                object result = mod.Call("GetDifficultyActive", "BossRush");
                if (result is bool b)
                {
                    flag = b;
                    num1 = 1;
                }
            }
            num2 = flag ? 1 : 0;
            num2 = flag ? 1 : 0;

            if ((num1 & num2) != 0)
                return false;

            if (FargoSoulsUtil.AnyBossAlive())
                return false;

            // Check accessories (slots 3–10 in armor array)
            for (int i = 3; i < 10 + player.extraAccessorySlots; i++)
            {
                if (player.armor[i] != null && player.armor[i].type == ModContent.ItemType<EternitySoul>())
                    return true;
            }

            return false;
        }
    }
}
