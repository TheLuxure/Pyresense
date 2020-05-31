using Pyresense.Tiles.Trophy;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Trophy
{
	public class PharaohTrophy : ModItem
	{
		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 10000;
			item.rare = 1;
			item.createTile = TileType<PharaohTrophy_Tile>();
		}

		public override int BossBagNPC => NPCType<Boss.Pharaoh.Pharaoh>();
	}
}