using AkiraIEoRMusic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernalEclipseAPI.Core.ModSceneEffects.RagnarokMusic
{
    [JITWhenModsEnabled("InfernumMode")]
    [ExtendsFromMod("InfernumMode")]
    public class BereftVassal : ModSceneEffect
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh + 1;

        public override bool IsLoadingEnabled(Mod mod)
        {
            return !ModLoader.HasMod("InfernalEclipseAPI");
        }

        public override int Music
        {
            get
            {
                if (MusicConfig.Instance.BereftVassal)
                    return MusicLoader.GetMusicSlot("InfernalEclipseAPI/Assets/Music/BereftVassal");

                if (ModLoader.TryGetMod("InfernumModeMusic", out Mod musicMod))
                    return MusicLoader.GetMusicSlot(musicMod, "Sounds/Music/BereftVassal");

                return MusicID.OldOnesArmy;
            }
        }

        public override bool IsSceneEffectActive(Player player)
        {
            bool bossRushActive = false;
            if (ModLoader.TryGetMod("CalamityMod", out Mod cal))
                bossRushActive = cal.Call("GetDifficultyActive", "bossrush") is bool b && b;

            if (!bossRushActive)
                return false;

            foreach (NPC npc in Main.ActiveNPCs)
            {
                if (!npc.active || npc.type != ModContent.NPCType<InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark.BereftVassal>())
                    continue;

                if (npc.ModNPC is not InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark.BereftVassal vassal)
                    continue;

                if (vassal.CurrentAttack != InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark.BereftVassal.BereftVassalAttackType.IdleState)
                    return true;
            }

            return false;
        }
    }
}
