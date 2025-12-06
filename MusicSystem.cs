using System;
using System.Reflection;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace AkiraIEoRMusic
{
    public class MusicSystem : ModSystem
    {
        private const BindingFlags UniversalBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

        private static readonly MethodInfo UpdateMI = typeof(LegacyAudioSystem).GetMethod(nameof(LegacyAudioSystem.Update), UniversalBindingFlags);

        private static Action<Orig_Update, LegacyAudioSystem> _updateDetour;

        public delegate void Orig_Update(LegacyAudioSystem self);

        public override void Load()
        {
            if (UpdateMI == null)
                return;

            _updateDetour ??= Update_Detour;
            MonoModHooks.Add(UpdateMI, _updateDetour);
        }

        private static void Update_Detour(Orig_Update orig, LegacyAudioSystem self)
        {
            Main.newMusic = OverrideMusicID(Main.newMusic);
            orig(self);
        }

        public static int OverrideMusicID(int i)
        {
            // Respect the main menu
            if (Main.gameMenu)
                return i;

            int original = i;
            var cfg = MusicConfig.Instance;

            //MusicID
            
            switch (i)
            {
                // Forest Day
                case 1:
                case 18:
                case 44:
                    if (cfg.ForestDay)
                        i = GetMusic("Weavers");
                    break;
                //Forset Night
                case 3:
                    if (cfg.ForestNight)
                        i = GetMusic("Unconscious");
                    break;
                /*
                // Underground
                case 4:
                case 31:
                    if (cfg.Underground)
                        i = GetMusic("");
                    break;
                */
                //Boss 1
                case 5:
                    if (cfg.Boss1)
                        i = GetMusic("Instinct");
                    break;
                // Jungle
                case 7:
                case 55:
                    if (cfg.Jungle)
                        i = GetMusic("Marshland");
                    break;

                // Corruption
                case 8:
                    if (cfg.CorruptionSurface)
                        i = GetMusic("RottenForest");
                    break;
                /*
                // Hallow
                case 9:
                    if (cfg.Hallow)
                        i = GetMusic("");
                    break;

                // Underground Corruption
                case 10:
                    if (cfg.UndergroundCorruption)
                        i = GetMusic("");
                    break;

                // Underground Hallow
                case 11:
                    if (cfg.UndergroundHallow)
                        i = GetMusic("");
                    break;

                // Snow / Tundra
                case 14:
                    if (cfg.Tundra)
                        i = GetMusic("");
                    break;
                */
                // Space
                case 15:
                case 42:
                    if (cfg.Space)
                        i = GetMusic("Floating");
                    break;

                // Crimson 
                case 16:
                    if (cfg.CrimsonSurface)
                        i = GetMusic("RottenForest");
                    break;
                /*
                // Rain
                case 19:
                    if (cfg.Rain)
                        i = GetMusic("");
                    break;

                // Underground Snow
                case 20:
                    if (cfg.UndergroundTundra)
                        i = GetMusic("");
                    break;

                // Desert (Surface)
                case 21:
                    if (cfg.Desert)
                        i = GetMusic("");
                    break;

                // Ocean (Surface / Night?)
                case 22:
                case 43:
                    if (cfg.Ocean)
                        i = GetMusic("");
                    break;

                // Dungeon
                case 23:
                    if (cfg.Dungeon)
                        i = GetMusic("");
                    break;
                */
                // Temple
                case 26:
                    if (cfg.Temple)
                        i = GetMusic("StarOfTheShow");
                    break;
                /*
                // Mushroom
                case 29:
                    if (cfg.Mushroom)
                        i = GetMusic("");
                    break;

                // Underground Crimson
                case 33:
                    if (cfg.UndergroundCrimson)
                        i = GetMusic("");
                    break;

                // Underworld
                case 36:
                    if (cfg.Underworld)
                        i = GetMusic("");
                    break;

                // Sandstorm
                case 40:
                    if (cfg.Sandstorm)
                        i = GetMusic("");
                    break;
                */
                // Town (Day / Night)
                case 46:
                    if (cfg.TownDay)
                        i = GetMusic("SafeHaven");
                    break;
                case 47:
                    if (cfg.TownNight)
                        i = GetMusic("SafeHavenO");
                    break;
                /*
                // Underground Jungle
                case 54:
                    if (cfg.UndergroundJungle)
                        i = GetMusic("");
                    break;

                // Underground Desert
                case 61:
                    if (cfg.UndergroundDesert)
                        i = GetMusic("");
                    break;
                */
            }

            return i >= Main.musicFade.Length ? original : i;
        }

        public static int GetMusic(string assetName)
        {
            return MusicLoader.GetMusicSlot(ModContent.GetInstance<AkiraIEoRMusic>(), $"Music/{assetName}");
        }
    }
}
 