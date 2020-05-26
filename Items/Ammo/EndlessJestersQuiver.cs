using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Ammo
{
	public class EndlessJestersQuiver : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless Jester's Quiver");
			//Tooltip.SetDefault("Summons Stars from sky!");
		}

		public override void SetDefaults() {
			item.CloneDefaults(51);
			item.consumable = false;
			item.maxStack = 1;
			item.rare = 3;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(51, 3196);
			recipe.AddTile(125);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}