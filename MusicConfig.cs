using System.ComponentModel;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace AkiraIEoRMusic
{
    public class MusicConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public static MusicConfig Instance => ModContent.GetInstance<MusicConfig>();

        [Header("Biomes")]
        [DefaultValue(true)]
        public bool ForestDay;

        [DefaultValue(true)]
        public bool ForestNight;

        [DefaultValue(true)]
        public bool Jungle;

        [DefaultValue(true)]
        public bool CorruptionSurface;

        [DefaultValue(true)]
        public bool Space;

        [DefaultValue(true)]
        public bool CrimsonSurface;

        [DefaultValue(true)]
        public bool Temple;

        [DefaultValue(true)]
        public bool TownDay;

        [DefaultValue(true)]
        public bool TownNight;

        [Header("Bosses")]
        [DefaultValue(true)]
        public bool Boss1;

        /*
        [DefaultValue(true)]
        public bool VanillaCalamityWoF;
        */

        [DefaultValue(true)]
        public bool MechBosses;

        [DefaultValue(true)]
        public bool Plantera;

        [DefaultValue(true)]
        public bool DukeFishron;

        [DefaultValue(true)]
        public bool Pillars;

        [DefaultValue(false)]
        [BackgroundColor(128, 0, 0)]
        public bool BereftVassal;

        [DefaultValue(false)]
        [BackgroundColor(112, 41, 99)]
        public bool SubspaceSerpent;

        [DefaultValue(true)]
        public bool MoonLord;

        [Header("Interludes")]
        [DefaultValue(true)]
        [BackgroundColor(0, 128, 128)]
        public bool MutantInterlude;

        [DefaultValue(true)]
        [BackgroundColor(0, 128, 128)]
        public bool SoulofEternityInterlude;
    }
}
