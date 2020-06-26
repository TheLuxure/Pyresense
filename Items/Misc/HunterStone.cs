using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Misc
{
	public class HunterStone : ModItem
	{
		private bool activeExp = false;

		public override void SetStaticDefaults() {
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults() {
			Item refItem = new Item();
			refItem.SetDefaults(ItemID.SoulofSight);
			item.width = refItem.width;
			item.height = refItem.height;
			item.maxStack = 999;
			item.value = 0;
			item.rare = 0;
			item.active = true;
		}

		public override void UpdateInventory(Player player) {
		}
		public override bool ItemSpace(Player player) {
			return true;
		}
		public override bool OnPickup(Player player) {
			item.active = false;
			if (!activeExp) {
				if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 1 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 2 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 3 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 4 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 5 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 6 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 7 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 8 * 60;
				} else if (Main.rand.NextBool(10)) {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 9 * 60;
				} else {
					ModContent.GetInstance<Pyresense>().skillHunterExp += 10 * 60;
				}
				activeExp = true;
			}
			return false;
		}

		// The following 2 methods are purely to show off these 2 hooks. Don't use them in your own code.
		public override void GrabRange(Player player, ref int grabRange) {
			grabRange *= 3;
		}

		public override bool GrabStyle(Player player) {
			Vector2 vectorItemToPlayer = player.Center - item.Center;
			Vector2 movement = -vectorItemToPlayer.SafeNormalize(default(Vector2)) * 0.1f;
			item.velocity = item.velocity + movement;
			item.velocity = Collision.TileCollision(item.position, item.velocity, item.width, item.height);
			return true;
		}
	}
}