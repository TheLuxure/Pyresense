using Pyresense.Items.Dev.CAT;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense
{
	public class PyresenseBossBags : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg) {
			//Reroll for devs
			if (context == "bossBag") {
				if (player.name == "CAT" || player.name == "Astral Cat" || player.name == "AstralCat" || player.name == "AstralCAT") {
					if (Main.rand.NextBool(10))
					{
						player.QuickSpawnItem(ItemType<MaskOfCAT>(), Main.rand.Next(1, 1));
						player.QuickSpawnItem(ItemType<RobeOfCAT>(), Main.rand.Next(1, 1));
						player.QuickSpawnItem(ItemType<WingsOfCAT>(), Main.rand.Next(1, 1));
						if (Main.rand.NextBool(4)) {
							player.QuickSpawnItem(ItemType<CatastrophicEdge>(), Main.rand.Next(1, 1));
						} else if (Main.rand.NextBool(4)) {
							player.QuickSpawnItem(ItemType<CATsThrow>(), Main.rand.Next(1, 1));
						} else if (Main.rand.NextBool(4)) {
							player.QuickSpawnItem(ItemType<TyrantsTear>(), Main.rand.Next(1, 1));
						} else {
							player.QuickSpawnItem(ItemType<AstralStars>(), Main.rand.Next(1, 1));
						}
					}
				}
			}
			//Normal roll for normies
			if (context == "bossBag") {
				if (Main.rand.NextBool(20)) {
					player.QuickSpawnItem(ItemType<MaskOfCAT>(), Main.rand.Next(1, 1));
					player.QuickSpawnItem(ItemType<RobeOfCAT>(), Main.rand.Next(1, 1));
					player.QuickSpawnItem(ItemType<WingsOfCAT>(), Main.rand.Next(1, 1));
					if (Main.rand.NextBool(4)) {
						player.QuickSpawnItem(ItemType<CatastrophicEdge>(), Main.rand.Next(1, 1));
					} else if (Main.rand.NextBool(4)) {
						player.QuickSpawnItem(ItemType<CATsThrow>(), Main.rand.Next(1, 1));
					} else if (Main.rand.NextBool(4)) {
						player.QuickSpawnItem(ItemType<TyrantsTear>(), Main.rand.Next(1, 1));
					} else {
						player.QuickSpawnItem(ItemType<AstralStars>(), Main.rand.Next(1, 1));
					}
				}
			}
		}
	}
}