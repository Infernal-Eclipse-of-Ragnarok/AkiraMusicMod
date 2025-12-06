using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AkiraIEoRMusic
{
    internal static class MusicUtils
    {
        private static Mod vanillaCalamity;
        private static Mod infernumMode;
        private static bool checkedUnCalamity;
        private static bool checkedInfernumMode;

        public static Mod VanillaCalamity
        {
            get
            {
                if (!checkedUnCalamity)
                {
                    checkedUnCalamity = true;
                    if (ModLoader.HasMod("UnCalamityModMusic"))
                        vanillaCalamity = ModLoader.GetMod("UnCalamityModMusic");
                }
                return vanillaCalamity;
            }
        }

        public static Mod InfernumMode
        {
            get
            {
                if (!checkedInfernumMode)
                {
                    checkedInfernumMode = true;
                    if (ModLoader.HasMod("InfernumModeMusic"))
                        infernumMode = ModLoader.GetMod("InfernumModeMusic");
                }
                return infernumMode;
            }
        }

        public static NPC FindClosestBoss(int type)
        {
            float num = 99999f;
            NPC closestBoss = null;
            foreach (NPC npc in Main.npc.Where(n => n != null && n.active && n.type == type))
            {
                if (npc.BossMusicRange() && npc.Distance(Main.LocalPlayer.Center) < num)
                {
                    num = npc.Distance(Main.LocalPlayer.Center);
                    closestBoss = npc;
                }
            }
            return closestBoss;
        }

        public static bool ZoneShallow(this Player player)
        {
            return player.ZoneDirtLayerHeight || player.ZoneOverworldHeight;
        }

        public static bool ZoneUnderground(this Player player)
        {
            return player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight;
        }

        public static bool BossMusicRange(this NPC npc)
        {
            const int range = 5500;

            var center = npc.Center.ToPoint();
            var bossRect = new Rectangle(center.X - range, center.Y - range, range * 2, range * 2);

            var screenRect = new Rectangle(
                (int)Main.screenPosition.X,
                (int)Main.screenPosition.Y,
                Main.screenWidth,
                Main.screenHeight);

            return screenRect.Intersects(bossRect);
        }

        public static int CountPillars()
        {
            int num1 = NPC.CountNPCS(517);
            int num2 = NPC.CountNPCS(422);
            int num3 = NPC.CountNPCS(507);
            int num4 = NPC.CountNPCS(493);
            int num5 = num2;
            return num1 + num5 + num3 + num4;
        }
    }
}
