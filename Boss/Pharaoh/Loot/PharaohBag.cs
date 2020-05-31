using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Boss.Pharaoh.Loot
{
	public class PharaohBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults() {
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 9;
			item.expert = true;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void OpenBossBag(Player player) {
			player.TryGettingDevArmor();
			if (Main.rand.NextBool(7)) {
				player.QuickSpawnItem(848);
			}
			if (Main.expertMode) {
				player.QuickSpawnItem(ItemType<Boss.Pharaoh.Loot.PharaohsMedallion>());
			}
		}

		public override int BossBagNPC => NPCType<Boss.Pharaoh.Pharaoh>();
	}
}