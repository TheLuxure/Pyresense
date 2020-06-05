using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Weapons.Magic
{
	public class FireBolt : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Inferno Bolt");
			Tooltip.SetDefault("Casts a fire bolt");
		}

		public override void SetDefaults() {
			item.CloneDefaults(112);
			item.damage = 50;
			item.noMelee = true;
			item.magic = true;
			item.mana = 8;
			item.rare = 4;
			item.width = 28;
			item.height = 30;
			item.useTime = 28;
			item.UseSound = SoundID.Item13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 26;
			item.shoot = 15;
			item.value = 20000;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(165, 1);
			recipe.AddIngredient(2701, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
