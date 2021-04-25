using Terraria.ModLoader;

namespace HealerMod
{
	class HealerMod : Mod
	{
		public static HealerMod Mod { get; private set; }
		public HealerMod()
		{
			Mod = this;
		}
	}
}
