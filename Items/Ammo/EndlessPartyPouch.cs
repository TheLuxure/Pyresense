using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Ammo
{
	public class EndlessPartyPouch : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless Party Pouch");
			//Tooltip.SetDefault("Summons Stars from sky!");
		}

		public override void SetDefaults() {
			item.CloneDefaults(1349);
			item.consumable = false;
			item.maxStack = 1;
			item.rare = 5;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1349, 7992);
			recipe.AddTile(125);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}