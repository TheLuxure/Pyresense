using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Ammo
{
	public class EndlessFlamingQuiver : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless Flaming Quiver");
			//Tooltip.SetDefault("Summons Stars from sky!");
		}

		public override void SetDefaults() {
			item.CloneDefaults(41);
			item.consumable = false;
			item.maxStack = 1;
			item.rare = 2;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(41, 1598);
			recipe.AddTile(125);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}