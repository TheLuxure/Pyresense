using Pyresense.Buffs.Summon;
using Pyresense.Minions;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Linq;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Weapons.Summon
{
	public class EyeStaff : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Summons eye to fight for you.");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true; // This lets the player target anywhere on the whole screen while using a controller.
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void SetDefaults() {
			item.damage = 8;
			item.knockBack = 0f;
			item.mana = 4;
			item.width = 32;
			item.height = 32;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.rare = 2;
			item.UseSound = SoundID.Item44;

			item.noMelee = true;
			item.summon = true;
			item.buffType = BuffType<Buffs.Summon.EyeofCthulhuBuff>();
			item.shoot = ProjectileType<Minions.EyeofCthulhuMinion>();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
			player.AddBuff(item.buffType, 2);

			position = Main.MouseWorld;
			return true;
		}
	}
}
