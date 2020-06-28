using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Ammo
{
	public class InkArrowProjBase : ModProjectile
	{
		public override string Texture
		{
			get
			{
				return "Pyresense/Items/Ammo/InkArrowProj";
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
			if (Main.rand.NextBool(3)) {
				target.AddBuff(24, 3 * 60);
			}
			if (Main.rand.NextBool(2)) {
				target.AddBuff(39, 7 * 60);
			} else {
				target.AddBuff(69, 10 * 60);
			}
			if (Main.rand.NextBool(1)) {
				target.AddBuff(70, 10 * 60);
			}
			if (Main.rand.NextBool(2)) {
				target.AddBuff(153, 6 * 60);
			}
			if (Main.rand.NextBool(2)) {
				target.AddBuff(20, 7 * 60);
			}
		}
	}
}