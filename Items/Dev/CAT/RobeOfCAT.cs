using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Dev.CAT
{
	[AutoloadEquip(EquipType.Body)]
	public class RobeOfCAT : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Robeof");
			Tooltip.SetDefault("'Great for impersonating devs!'");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.rare = ItemRarityID.Cyan;
			item.vanity = true;
		}

		public override void UpdateEquip(Player player) {
			if (player.name == "CAT") {
				player.buffImmune[BuffID.OnFire] = true;
				player.statLifeMax2 += 20;
				player.maxMinions++;
			}
			if (player.name == "AstralCat") {
				player.buffImmune[BuffID.OnFire] = true;
				player.statLifeMax2 += 20;
				player.maxMinions++;
			}
		}
	}
}