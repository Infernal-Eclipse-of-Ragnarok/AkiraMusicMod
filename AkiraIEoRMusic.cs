using Terraria.ModLoader;

namespace AkiraIEoRMusic
{
    public class AkiraIEoRMusic : Mod
	{
		internal static AkiraIEoRMusic Instance;

		public override void Load() => Instance = this;

		public override void Unload() => Instance = null;
    }
}
