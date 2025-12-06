using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using System.Linq;

namespace AkiraIEoRMusic.MusicEffects
{
    internal class MechBosses : MusicEffect
    {
        public static List<int> MechIDs = new List<int>()
        {
        sbyte.MaxValue,
        134,
        125,
        126
        };

        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh + 3;

        public override string MusicName
        {
            get
            {
                int num = (NPC.downedMechBoss1 ? 1 : 0) + (NPC.downedMechBoss2 ? 1 : 0) + (NPC.downedMechBoss3 ? 1 : 0);
                if (num <= 0)
                    return ABSectionPerPhase("WarWithoutReasonA1", "WarWithoutReasonA2");
                return num <= 1 ? ABSectionPerPhase("WarWithoutReasonB1", "WarWithoutReasonB2") : "WarWithoutReasonC";

                static string ABSectionPerPhase(string p1, string p2)
                {
                    return Main.npc.Any(n => n != null && n.active && MechIDs.Contains(n.type) && n.life < n.lifeMax / 2) ? p2 : p1;
                }
            }
        }

        public override bool Config => MusicConfig.Instance.MechBosses;

        public override bool Active(Player player)
        {
            return Main.npc.Any(n => n != null && (n.active && MechIDs.Contains(n.type)));
        }
    }
}
