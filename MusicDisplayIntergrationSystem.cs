using Terraria.ModLoader;

namespace AkiraIEoRMusic
{
    public class MusicDisplayIntergrationSystem : ModSystem
    {
        public override void PostSetupContent()
        {
            MusicDisplaySetup();
        }

        private static void MusicDisplaySetup()
        {
            ModLoader.TryGetMod("MusicDisplay", out Mod musicDisplay);

            if (musicDisplay == null)
                return;

            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/SewerCreature"), "Sewer Creature", "by NoLongerNull", "Pressure | VOLUME 2");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/SewerCreatureCut"), "Sewer Creature", "by NoLongerNull", "Pressure | VOLUME 2");

            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/titan_battle"), "GUARDIAN", "by Toby Fox", "DELTARUNE Chapter 4");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/SPAWN"), "Dark Fountain (Titan Spawn)", "by fluffyhairs & Toby Fox", "");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/GUARDIAN"), "GUARDIAN", "by RGredsky & Toby Fox", "");

            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/Axion"), "Axion", "by Sakuzyo", "Selentia");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/EndofStory"), "End of Story", "by Sakuzyo", "Selentia");

            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/Instinct"), "Instinct", "by Sakuzyo", "WARZ0NE");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/Neurotoxin"), "Neurotoxin", "by Sakuzyo", "Selentia");

            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/RottenForest"), "Rotten Forest", "by Sakuzyo", "WARZ0NE");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/StarOfTheShow"), "Star Of The Show", "by NoLongerNull", "Pressure | The Hunted");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/Weavers"), "Weavers", "by Sakuzyo", "Forest Funk");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/Marshland"), "Marshland", "by Sakuzyo", "Forest Funk");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/Floating"), "Floating", "by Sakuzyo", "Creamy Room");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/Unconscious"), "Unconscious", "by Sakuzyo", "Creamy Room");

            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/SafeHaven"), "Safe Haven", "by Yoko Shimomura", "FINAL FANTASY XV"); //Day
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/SafeHavenO"), "Safe Haven", "by Orvynx ft. Yoko Shimomura", ""); //Night

            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/WarWithoutReasonA1"), "War Without Reason (Type A-1)", "by Heaven Pierce Her", "ULTRAKILL: VIOLENCE");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/WarWithoutReasonA2"), "War Without Reason (Type A-2)", "by Heaven Pierce Her", "ULTRAKILL: VIOLENCE");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/WarWithoutReasonB1"), "War Without Reason (Type B-1)", "by Heaven Pierce Her", "ULTRAKILL: VIOLENCE");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/WarWithoutReasonB2"), "War Without Reason (Type B-2)", "by Heaven Pierce Her", "ULTRAKILL: VIOLENCE");
            musicDisplay.Call("AddMusic", (short)MusicLoader.GetMusicSlot("AkiraIEoRMusic/Music/WarWithoutReasonC"), "War Without Reason (Type C)", "by Heaven Pierce Her", "ULTRAKILL: VIOLENCE");
        }
    }
}
