using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Misc
{
	public class AnyVanillaArrow : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Arrow");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 12));
		}

		public override void SetDefaults() {
			item.width = 14;
			item.height = 38;
			item.maxStack = 1;
			item.value = 0;
			item.rare = 0;
		}
	}
}